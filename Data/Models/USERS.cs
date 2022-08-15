using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class USERS{
		public int USER_ID {get; set;}
		public String GLOBAL_FLAG {get; set;}
		public String EMAIL_TYPE {get; set;}
		public String USER_NAME {get; set;}
		public int PROF_ID {get; set;}
		public int CURR_ID {get; set;}
		public String GUID {get; set;}
		public String EMAIL_SRV_USER_NAME {get; set;}
		public String OFFICE_PHONE {get; set;}
		public String ACTUAL_NAME {get; set;}
		public String EMAIL_SEND_SERVER {get; set;}
		public String EMAIL_ADDR {get; set;}
		public String EMAIL_SRV_PASSWD {get; set;}
		public String PASSWD {get; set;}
		public String ALL_RSRC_ACCESS_FLAG {get; set;}
		public String CR_EXTERNAL_KEY {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}