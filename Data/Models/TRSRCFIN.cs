using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class TRSRCFIN{
		public int FIN_DATES_ID {get; set;}
		public int TASKRSRC_ID {get; set;}
		public int TASK_ID {get; set;}
		public int PROJ_ID {get; set;}
		public float ACT_QTY {get; set;}
		public float ACT_COST {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}