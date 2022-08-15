import requests
import os
import pandas as pd
import sqlalchemy as sql
from sqlalchemy.ext.automap import automap_base
from sqlalchemy.orm import Session
from sqlalchemy import create_engine, inspect, func, MetaData
import datetime as dt
import pyodbc




def main(connectionSTR = "mssql+pyodbc://DESKTOP-VAUEP5A\SQLEXPRESS/Dash360?driver=SQL+Server+Native+Client+11.0", filename = "Dash360DB", primavera = False):
    engine = create_engine(connectionSTR)
    inspector = inspect(engine)
    Base = automap_base()
    Base.prepare(engine, reflect=True) 
    dbDesign = ""
    if primavera:
        dbDesign = dynamicFKCreation(Base, inspector)
    else:
        for tableName in Base.classes.keys():
            dbDesign += tableName
            dbDesign += "\n---\n"
            pk = inspector.get_pk_constraint(tableName)['constrained_columns']
            fks = inspector.get_foreign_keys(tableName)
            fkNames = [z['constrained_columns'][0] for z in fks]
            for column in inspector.get_columns(tableName):
                dbDesign += column['name']
                if column['name'] in pk:
                    dbDesign += " PK"
                if column['name'] in fkNames:
                    for item in fks:
                        for c in item['constrained_columns']:
                            if column['name'] == c:
                                dbDesign += " FK - " + item['referred_table']+ "." + item['referred_columns'][0]
                dbDesign+= "\n"
            dbDesign+="\n"
    f = open(filename+ ".txt", "w")
    f.write(dbDesign)
    f.close()


def createPKTableNameDictionary(Base, inspector):
    temp=[[{col:table} for col in inspector.get_pk_constraint(table)['constrained_columns'] if len(inspector.get_pk_constraint(table)['constrained_columns']) ==1 ] for table in Base.classes.keys()]
    result = []
    for x in temp:
        [result.append(y) for y in x]
    pks = {}
    for i in result:
        for k,v in i.items():
            pks[k] = v
    return pks

def dynamicFKCreation(Base, inspector):
    dbDesign = ""
    fks = generateTableNameFKS(Base,inspector)
    for tableName in Base.classes.keys():
        dbDesign += tableName
        dbDesign += "\n---\n"
        pk = inspector.get_pk_constraint(tableName)['constrained_columns']
        if tableName in fks.keys():
            foreignKeyStrings = fks[tableName]
            foreignKeyValues = [x.split(" ")[0] for x in foreignKeyStrings]
        else:
            foreignKeyStrings = [""]
            foreignKeyValues=[""]
        for column in inspector.get_columns(tableName):
            if column['name'] in pk:
                dbDesign += column['name'] +" PK"
            elif column['name'] in foreignKeyValues:
                dbDesign += foreignKeyStrings[foreignKeyValues.index(column['name'])]
            else:
                dbDesign += column['name']
            dbDesign+= "\n"
        dbDesign+= "\n"
    return dbDesign

def generateTableNameFKS(Base, inspector):
    pks = createPKTableNameDictionary(Base, inspector)
    fks = {}
    for table in Base.classes.keys():
        columns = inspector.get_columns(table)
        for col in columns:
            if col['name'] in pks.keys():
                try:
                    fks[table].append( col['name'] +" FK - " + pks[col['name']]+f".{col['name']}")
                except:
                    fks[table] = [col['name'] +" FK - " + pks[col['name']]+f".{col['name']}"]
    return fks



if __name__ =="__main__":
    main()

