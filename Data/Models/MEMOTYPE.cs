using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class MEMOTYPE{
		public int MEMO_TYPE_ID {get; set;}
		public int SEQ_NUM {get; set;}
		public String EPS_FLAG {get; set;}
		public String PROJ_FLAG {get; set;}
		public String WBS_FLAG {get; set;}
		public String TASK_FLAG {get; set;}
		public String MEMO_TYPE {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}