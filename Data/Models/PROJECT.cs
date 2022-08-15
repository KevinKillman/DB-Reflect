using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PROJECT{
		public int PROJ_ID {get; set;}
		public int FY_START_MONTH_NUM {get; set;}
		public String RSRC_SELF_ADD_FLAG {get; set;}
		public String ALLOW_COMPLETE_FLAG {get; set;}
		public String RSRC_MULTI_ASSIGN_FLAG {get; set;}
		public String CHECKOUT_FLAG {get; set;}
		public String PROJECT_FLAG {get; set;}
		public String STEP_COMPLETE_FLAG {get; set;}
		public String COST_QTY_RECALC_FLAG {get; set;}
		public String BATCH_SUM_FLAG {get; set;}
		public String NAME_SEP_CHAR {get; set;}
		public String DEF_COMPLETE_PCT_TYPE {get; set;}
		public String PROJ_SHORT_NAME {get; set;}
		public int ACCT_ID {get; set;}
		public int ORIG_PROJ_ID {get; set;}
		public int SOURCE_PROJ_ID {get; set;}
		public int BASE_TYPE_ID {get; set;}
		public int CLNDR_ID {get; set;}
		public int SUM_BASE_PROJ_ID {get; set;}
		public int TASK_CODE_BASE {get; set;}
		public int TASK_CODE_STEP {get; set;}
		public int PRIORITY_NUM {get; set;}
		public int WBS_MAX_SUM_LEVEL {get; set;}
		public int STRGY_PRIORITY_NUM {get; set;}
		public int LAST_CHECKSUM {get; set;}
		public float CRITICAL_DRTN_HR_CNT {get; set;}
		public float DEF_COST_PER_QTY {get; set;}
		public DateTime LAST_RECALC_DATE {get; set;}
		public DateTime PLAN_START_DATE {get; set;}
		public DateTime PLAN_END_DATE {get; set;}
		public DateTime SCD_END_DATE {get; set;}
		public DateTime ADD_DATE {get; set;}
		public DateTime LAST_TASKSUM_DATE {get; set;}
		public DateTime FCST_START_DATE {get; set;}
		public String DEF_DURATION_TYPE {get; set;}
		public String TASK_CODE_PREFIX {get; set;}
		public String GUID {get; set;}
		public String DEF_QTY_TYPE {get; set;}
		public String ADD_BY_NAME {get; set;}
		public String WEB_LOCAL_ROOT_PATH {get; set;}
		public String PROJ_URL {get; set;}
		public String DEF_RATE_TYPE {get; set;}
		public String ADD_ACT_REMAIN_FLAG {get; set;}
		public String ACT_THIS_PER_LINK_FLAG {get; set;}
		public String DEF_TASK_TYPE {get; set;}
		public String ACT_PCT_LINK_FLAG {get; set;}
		public String CRITICAL_PATH_TYPE {get; set;}
		public String TASK_CODE_PREFIX_FLAG {get; set;}
		public String DEF_ROLLUP_DATES_FLAG {get; set;}
		public String USE_PROJECT_BASELINE_FLAG {get; set;}
		public String REM_TARGET_LINK_FLAG {get; set;}
		public String RESET_PLANNED_FLAG {get; set;}
		public String ALLOW_NEG_ACT_FLAG {get; set;}
		public DateTime CHECKOUT_DATE {get; set;}
		public int CHECKOUT_USER_ID {get; set;}
		public String SUM_ASSIGN_LEVEL {get; set;}
		public int LAST_FIN_DATES_ID {get; set;}
		public DateTime LAST_BASELINE_UPDATE_DATE {get; set;}
		public String CR_EXTERNAL_KEY {get; set;}
		public DateTime APPLY_ACTUALS_DATE {get; set;}
		public int LOCATION_ID {get; set;}
		public int FINTMPL_ID {get; set;}
		public String CONTROL_UPDATES_FLAG {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}