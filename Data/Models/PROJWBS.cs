using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PROJWBS{
		public int WBS_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int OBS_ID {get; set;}
		public int SEQ_NUM {get; set;}
		public float EST_WT {get; set;}
		public String PROJ_NODE_FLAG {get; set;}
		public String SUM_DATA_FLAG {get; set;}
		public String STATUS_CODE {get; set;}
		public String WBS_SHORT_NAME {get; set;}
		public String WBS_NAME {get; set;}
		public int PHASE_ID {get; set;}
		public int PARENT_WBS_ID {get; set;}
		public int EV_USER_PCT {get; set;}
		public float EV_ETC_USER_VALUE {get; set;}
		public float ORIG_COST {get; set;}
		public float INDEP_REMAIN_TOTAL_COST {get; set;}
		public float ANN_DSCNT_RATE_PCT {get; set;}
		public String DSCNT_PERIOD_TYPE {get; set;}
		public float INDEP_REMAIN_WORK_QTY {get; set;}
		public DateTime ANTICIP_START_DATE {get; set;}
		public DateTime ANTICIP_END_DATE {get; set;}
		public String EV_COMPUTE_TYPE {get; set;}
		public String EV_ETC_COMPUTE_TYPE {get; set;}
		public String GUID {get; set;}
		public String TMPL_GUID {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}