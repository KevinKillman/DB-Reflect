using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class UDFVALUE{
		public int UDF_TYPE_ID {get; set;}
		public int FK_ID {get; set;}
		public int PROJ_ID {get; set;}
		public DateTime UDF_DATE {get; set;}
		public float UDF_NUMBER {get; set;}
		public String UDF_TEXT {get; set;}
		public int UDF_CODE_ID {get; set;}
		public String TABLE_NAME {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}