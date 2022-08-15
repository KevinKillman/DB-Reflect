using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class EXTAPP{
		public int APP_ID {get; set;}
		public String LOGIN_SUPPLY_FLAG {get; set;}
		public String APP_NAME {get; set;}
		public String APP_EXE_NAME {get; set;}
		public int PROJ_ID {get; set;}
		public String APP_USER_NAME {get; set;}
		public String APP_PASSWD {get; set;}
		public String APP_DATA_NAME {get; set;}
		public String APP_PARM_STRING {get; set;}
		public String APP_DATA_LOC {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}