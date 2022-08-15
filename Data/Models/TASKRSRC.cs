using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class TASKRSRC{
		public int TASKRSRC_ID {get; set;}
		public int TASK_ID {get; set;}
		public int PROJ_ID {get; set;}
		public String COST_QTY_LINK_FLAG {get; set;}
		public int ROLE_ID {get; set;}
		public int ACCT_ID {get; set;}
		public int RSRC_ID {get; set;}
		public int POBS_ID {get; set;}
		public int SKILL_LEVEL {get; set;}
		public float REMAIN_QTY {get; set;}
		public float TARGET_QTY {get; set;}
		public float REMAIN_QTY_PER_HR {get; set;}
		public float TARGET_LAG_DRTN_HR_CNT {get; set;}
		public float TARGET_QTY_PER_HR {get; set;}
		public float ACT_OT_QTY {get; set;}
		public float ACT_REG_QTY {get; set;}
		public float RELAG_DRTN_HR_CNT {get; set;}
		public float OT_FACTOR {get; set;}
		public float COST_PER_QTY {get; set;}
		public float TARGET_COST {get; set;}
		public float ACT_REG_COST {get; set;}
		public float ACT_OT_COST {get; set;}
		public float REMAIN_COST {get; set;}
		public DateTime ACT_START_DATE {get; set;}
		public DateTime ACT_END_DATE {get; set;}
		public DateTime RESTART_DATE {get; set;}
		public DateTime REEND_DATE {get; set;}
		public DateTime TARGET_START_DATE {get; set;}
		public DateTime TARGET_END_DATE {get; set;}
		public DateTime REM_LATE_START_DATE {get; set;}
		public DateTime REM_LATE_END_DATE {get; set;}
		public String ROLLUP_DATES_FLAG {get; set;}
		public String TARGET_CRV {get; set;}
		public String REMAIN_CRV {get; set;}
		public String ACTUAL_CRV {get; set;}
		public String TS_PEND_ACT_END_FLAG {get; set;}
		public String GUID {get; set;}
		public String RATE_TYPE {get; set;}
		public float ACT_THIS_PER_COST {get; set;}
		public float ACT_THIS_PER_QTY {get; set;}
		public int CURV_ID {get; set;}
		public String RSRC_TYPE {get; set;}
		public String COST_PER_QTY_SOURCE_TYPE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}