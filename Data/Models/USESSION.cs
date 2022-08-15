using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class USESSION{
		public int SESSION_ID {get; set;}
		public DateTime LOGIN_TIME {get; set;}
		public DateTime LAST_ACTIVE_TIME {get; set;}
		public String HOST_NAME {get; set;}
		public int USER_ID {get; set;}
		public int PROCESS_NUM {get; set;}
		public String APP_NAME {get; set;}
		public String HARD_DRIVE_CODE {get; set;}
		public String DB_ENGINE_TYPE {get; set;}
		public String OS_USER_NAME {get; set;}
		public String VDB_INSTANCE_GUID {get; set;}
		public int SPID {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}