using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class SUMTRSRC{
		public int SUMTRSRC_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int WBS_ID {get; set;}
		public DateTime START_DATE {get; set;}
		public DateTime END_DATE {get; set;}
		public String SPREAD_TYPE {get; set;}
		public int RSRC_ID {get; set;}
		public int ROLE_ID {get; set;}
		public float STAFFED_ACT_QTY {get; set;}
		public float UNSTAFFED_ACT_QTY {get; set;}
		public float ACT_QTY {get; set;}
		public float STAFFED_ACT_COST {get; set;}
		public float UNSTAFFED_ACT_COST {get; set;}
		public float ACT_COST {get; set;}
		public float STAFFED_ACT_OT_QTY {get; set;}
		public float UNSTAFFED_ACT_OT_QTY {get; set;}
		public float ACT_OT_QTY {get; set;}
		public float STAFFED_ACT_OT_COST {get; set;}
		public float UNSTAFFED_ACT_OT_COST {get; set;}
		public float ACT_OT_COST {get; set;}
		public float STAFFED_ACT_REG_COST {get; set;}
		public float UNSTAFFED_ACT_REG_COST {get; set;}
		public float ACT_REG_COST {get; set;}
		public float STAFFED_ACT_REG_QTY {get; set;}
		public float UNSTAFFED_ACT_REG_QTY {get; set;}
		public float ACT_REG_QTY {get; set;}
		public float STAFFED_LATE_REMAIN_QTY {get; set;}
		public float UNSTAFFED_LATE_REMAIN_QTY {get; set;}
		public float LATE_REMAIN_QTY {get; set;}
		public float STAFFED_LATE_REMAIN_COST {get; set;}
		public float UNSTAFFED_LATE_REMAIN_COST {get; set;}
		public float LATE_REMAIN_COST {get; set;}
		public float STAFFED_REMAIN_QTY {get; set;}
		public float UNSTAFFED_REMAIN_QTY {get; set;}
		public float REMAIN_QTY {get; set;}
		public float STAFFED_REMAIN_COST {get; set;}
		public float UNSTAFFED_REMAIN_COST {get; set;}
		public float REMAIN_COST {get; set;}
		public float STAFFED_TARGET_QTY {get; set;}
		public float UNSTAFFED_TARGET_QTY {get; set;}
		public float TARGET_QTY {get; set;}
		public float STAFFED_TARGET_COST {get; set;}
		public float UNSTAFFED_TARGET_COST {get; set;}
		public float TARGET_COST {get; set;}
		public float STAFFED_TOTAL_QTY {get; set;}
		public float UNSTAFFED_TOTAL_QTY {get; set;}
		public float TOTAL_QTY {get; set;}
		public float STAFFED_TOTAL_COST {get; set;}
		public float UNSTAFFED_TOTAL_COST {get; set;}
		public float TOTAL_COST {get; set;}
		public float FIN_PERIOD_ACT_QTY {get; set;}
		public float FIN_PERIOD_ACT_COST {get; set;}
		public float FIN_PERIOD_TOTAL_QTY {get; set;}
		public float FIN_PERIOD_TOTAL_COST {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}