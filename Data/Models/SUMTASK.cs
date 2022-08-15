using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class SUMTASK{
		public int WBS_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int COMPLETE_CNT {get; set;}
		public int ACTIVE_CNT {get; set;}
		public int NOTSTARTED_CNT {get; set;}
		public int BASE_COMPLETE_CNT {get; set;}
		public int BASE_ACTIVE_CNT {get; set;}
		public int BASE_NOTSTARTED_CNT {get; set;}
		public float ACT_DRTN_HR_CNT {get; set;}
		public float ACT_EQUIP_QTY {get; set;}
		public float ACT_WORK_QTY {get; set;}
		public float TOTAL_DRTN_HR_CNT {get; set;}
		public float BASE_DRTN_HR_CNT {get; set;}
		public float BASE_WORK_QTY {get; set;}
		public float BASE_EQUIP_QTY {get; set;}
		public float ETC_WORK_QTY {get; set;}
		public float REMAIN_DRTN_HR_CNT {get; set;}
		public float REMAIN_WORK_QTY {get; set;}
		public float REMAIN_EQUIP_QTY {get; set;}
		public float TOTAL_FLOAT_HR_CNT {get; set;}
		public float ACT_EXPENSE_COST {get; set;}
		public float ACT_WORK_COST {get; set;}
		public float ACT_EQUIP_COST {get; set;}
		public float BASE_EXPENSE_COST {get; set;}
		public float BASE_WORK_COST {get; set;}
		public float BASE_EQUIP_COST {get; set;}
		public float BCWP {get; set;}
		public float ETC {get; set;}
		public float BCWS {get; set;}
		public float REMAIN_EXPENSE_COST {get; set;}
		public float REMAIN_WORK_COST {get; set;}
		public float REMAIN_EQUIP_COST {get; set;}
		public float PERFM_WORK_QTY {get; set;}
		public float SCHED_WORK_QTY {get; set;}
		public DateTime ACT_END_DATE {get; set;}
		public DateTime ACT_START_DATE {get; set;}
		public DateTime BASE_END_DATE {get; set;}
		public DateTime BASE_START_DATE {get; set;}
		public DateTime REEND_DATE {get; set;}
		public DateTime RESTART_DATE {get; set;}
		public float ACT_THIS_PER_WORK_COST {get; set;}
		public float ACT_THIS_PER_WORK_QTY {get; set;}
		public float ACT_THIS_PER_EQUIP_COST {get; set;}
		public float ACT_THIS_PER_EQUIP_QTY {get; set;}
		public float BASE_MAT_COST {get; set;}
		public float REMAIN_MAT_COST {get; set;}
		public float ACT_MAT_COST {get; set;}
		public float ACT_THIS_PER_MAT_COST {get; set;}
		public float EAC_WORK_QTY {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}