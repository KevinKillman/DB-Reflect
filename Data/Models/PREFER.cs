using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PREFER{
		public int PREFER_ID {get; set;}
		public int MAX_WBS_LEVEL_CNT {get; set;}
		public int MAX_RSRC_LEVEL_CNT {get; set;}
		public int MAX_ACCT_LEVEL_CNT {get; set;}
		public int MAX_TASK_ACTV_TYPE_CNT {get; set;}
		public int MAX_OBS_LEVEL_CNT {get; set;}
		public int WEEK_START_DAY_NUM {get; set;}
		public int TASK_CODE_LEN {get; set;}
		public int PROJ_SHORT_LEN {get; set;}
		public int WBS_SHORT_LEN {get; set;}
		public int RSRC_SHORT_LEN {get; set;}
		public int ACCT_SHORT_LEN {get; set;}
		public int ROLE_SHORT_LEN {get; set;}
		public int MAX_BASE_CNT {get; set;}
		public float DEF_TARGET_DRTN_HR_CNT {get; set;}
		public float DAY_HR_CNT {get; set;}
		public float WEEK_HR_CNT {get; set;}
		public float YEAR_HR_CNT {get; set;}
		public float MONTH_HR_CNT {get; set;}
		public int MAX_ACTV_LEVEL_CNT {get; set;}
		public int MAX_EPS_LEVEL_CNT {get; set;}
		public int MAX_PCAT_LEVEL_CNT {get; set;}
		public int MAX_RCAT_LEVEL_CNT {get; set;}
		public String EV_FIX_COST_FLAG {get; set;}
		public String NAME_SEP_CHAR {get; set;}
		public String YEAR_CHAR {get; set;}
		public String MONTH_CHAR {get; set;}
		public String WEEK_CHAR {get; set;}
		public String DAY_CHAR {get; set;}
		public String HOUR_CHAR {get; set;}
		public String MINUTE_CHAR {get; set;}
		public String DB_NAME {get; set;}
		public String TASKSUM_PERIOD_TYPE {get; set;}
		public String TRSRCSUM_PERIOD_TYPE {get; set;}
		public String DATABASE_VERSION {get; set;}
		public String PHASE_LABEL {get; set;}
		public int CURR_ID {get; set;}
		public int EV_USER_PCT {get; set;}
		public float EV_ETC_USER_VALUE {get; set;}
		public String EV_COMPUTE_TYPE {get; set;}
		public String EV_ETC_COMPUTE_TYPE {get; set;}
		public String RPT_HEADER_1 {get; set;}
		public String RPT_HEADER_2 {get; set;}
		public String RPT_HEADER_3 {get; set;}
		public String RPT_FOOTER_1 {get; set;}
		public String RPT_FOOTER_2 {get; set;}
		public String RPT_FOOTER_3 {get; set;}
		public String RPT_USER_1 {get; set;}
		public String RPT_USER_2 {get; set;}
		public String RPT_USER_3 {get; set;}
		public String LICENSE_DATA {get; set;}
		public int MAX_ROLE_LEVEL_CNT {get; set;}
		public String EXP_ROOT_URL {get; set;}
		public String ALLOW_USER_TIME_PERIOD_FLAG {get; set;}
		public String MIN_PRO_VERSION {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}