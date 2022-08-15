using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class RPT{
		public int RPT_ID {get; set;}
		public int RPT_GROUP_ID {get; set;}
		public String RPT_TYPE {get; set;}
		public String RPT_NAME {get; set;}
		public String GLOBAL_FLAG {get; set;}
		public int PROJ_ID {get; set;}
		public String RPT_STATE {get; set;}
		public DateTime LAST_RUN_DATE {get; set;}
		public String RPT_AREA {get; set;}
		public int USER_ID {get; set;}
		public byte[] RPT_DATA {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}