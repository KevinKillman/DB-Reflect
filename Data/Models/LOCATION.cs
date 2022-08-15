using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class LOCATION{
		public int LOCATION_ID {get; set;}
		public String LOCATION_NAME {get; set;}
		public String LOCATION_TYPE {get; set;}
		public String ADDRESS_LINE1 {get; set;}
		public String ADDRESS_LINE2 {get; set;}
		public String ADDRESS_LINE3 {get; set;}
		public String CITY_NAME {get; set;}
		public String MUNICIPALITY_NAME {get; set;}
		public String STATE_NAME {get; set;}
		public String STATE_CODE {get; set;}
		public String COUNTRY_NAME {get; set;}
		public String COUNTRY_CODE {get; set;}
		public String POSTAL_CODE {get; set;}
		public float LONGITUDE {get; set;}
		public float LATITUDE {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}