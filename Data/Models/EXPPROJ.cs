using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class EXPPROJ{
		public int PROJ_ID {get; set;}
		public String EXP_GROUP {get; set;}
		public String EXP_PROJ_NAME {get; set;}
		public String LOGIN_SUPPLIED_FLAG {get; set;}
		public String EXP_USER_NAME {get; set;}
		public String EXP_PASSWD {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}