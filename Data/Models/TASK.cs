using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class TASK{
		public int TASK_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int WBS_ID {get; set;}
		public int CLNDR_ID {get; set;}
		public float PHYS_COMPLETE_PCT {get; set;}
		public String REV_FDBK_FLAG {get; set;}
		public float EST_WT {get; set;}
		public String LOCK_PLAN_FLAG {get; set;}
		public String AUTO_COMPUTE_ACT_FLAG {get; set;}
		public String COMPLETE_PCT_TYPE {get; set;}
		public String TASK_TYPE {get; set;}
		public String DURATION_TYPE {get; set;}
		public String STATUS_CODE {get; set;}
		public String TASK_CODE {get; set;}
		public String TASK_NAME {get; set;}
		public int RSRC_ID {get; set;}
		public float TOTAL_FLOAT_HR_CNT {get; set;}
		public float FREE_FLOAT_HR_CNT {get; set;}
		public float REMAIN_DRTN_HR_CNT {get; set;}
		public float ACT_WORK_QTY {get; set;}
		public float REMAIN_WORK_QTY {get; set;}
		public float TARGET_WORK_QTY {get; set;}
		public float TARGET_DRTN_HR_CNT {get; set;}
		public float TARGET_EQUIP_QTY {get; set;}
		public float ACT_EQUIP_QTY {get; set;}
		public float REMAIN_EQUIP_QTY {get; set;}
		public DateTime CSTR_DATE {get; set;}
		public DateTime ACT_START_DATE {get; set;}
		public DateTime ACT_END_DATE {get; set;}
		public DateTime LATE_START_DATE {get; set;}
		public DateTime LATE_END_DATE {get; set;}
		public DateTime EXPECT_END_DATE {get; set;}
		public DateTime EARLY_START_DATE {get; set;}
		public DateTime EARLY_END_DATE {get; set;}
		public DateTime RESTART_DATE {get; set;}
		public DateTime REEND_DATE {get; set;}
		public DateTime TARGET_START_DATE {get; set;}
		public DateTime TARGET_END_DATE {get; set;}
		public DateTime REM_LATE_START_DATE {get; set;}
		public DateTime REM_LATE_END_DATE {get; set;}
		public String CSTR_TYPE {get; set;}
		public String PRIORITY_TYPE {get; set;}
		public DateTime SUSPEND_DATE {get; set;}
		public DateTime RESUME_DATE {get; set;}
		public int FLOAT_PATH {get; set;}
		public int FLOAT_PATH_ORDER {get; set;}
		public String GUID {get; set;}
		public String TMPL_GUID {get; set;}
		public DateTime CSTR_DATE2 {get; set;}
		public String CSTR_TYPE2 {get; set;}
		public String DRIVING_PATH_FLAG {get; set;}
		public float ACT_THIS_PER_WORK_QTY {get; set;}
		public float ACT_THIS_PER_EQUIP_QTY {get; set;}
		public DateTime EXTERNAL_EARLY_START_DATE {get; set;}
		public DateTime EXTERNAL_LATE_END_DATE {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public String UPDATE_USER {get; set;}
		public int LOCATION_ID {get; set;}
		public float SCP_PCT_COMPLETE {get; set;}
		public String CONTROL_UPDATES_FLAG {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}