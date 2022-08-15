using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class TASKPROC{
		public int PROC_ID {get; set;}
		public int TASK_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int SEQ_NUM {get; set;}
		public String PROC_NAME {get; set;}
		public String COMPLETE_FLAG {get; set;}
		public float PROC_WT {get; set;}
		public float COMPLETE_PCT {get; set;}
		public byte[] PROC_DESCR {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}