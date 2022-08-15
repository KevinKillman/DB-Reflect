using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class BUDGCHNG{
		public int BUDG_CHNG_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int WBS_ID {get; set;}
		public String CHNG_BY_NAME {get; set;}
		public String CHNG_SHORT_NAME {get; set;}
		public DateTime CHNG_DATE {get; set;}
		public float CHNG_COST {get; set;}
		public String STATUS_CODE {get; set;}
		public String CHNG_DESCR {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}