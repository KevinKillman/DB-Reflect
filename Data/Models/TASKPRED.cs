using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class TASKPRED{
		public int TASK_PRED_ID {get; set;}
		public int TASK_ID {get; set;}
		public int PRED_TASK_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int PRED_PROJ_ID {get; set;}
		public String PRED_TYPE {get; set;}
		public float LAG_HR_CNT {get; set;}
		public String COMMENTS {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}