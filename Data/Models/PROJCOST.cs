using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PROJCOST{
		public int COST_ITEM_ID {get; set;}
		public int ACCT_ID {get; set;}
		public int POBS_ID {get; set;}
		public int COST_TYPE_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int TASK_ID {get; set;}
		public String COST_NAME {get; set;}
		public String PO_NUMBER {get; set;}
		public String VENDOR_NAME {get; set;}
		public float ACT_COST {get; set;}
		public float COST_PER_QTY {get; set;}
		public float REMAIN_COST {get; set;}
		public float TARGET_COST {get; set;}
		public String COST_LOAD_TYPE {get; set;}
		public String AUTO_COMPUTE_ACT_FLAG {get; set;}
		public float TARGET_QTY {get; set;}
		public String QTY_NAME {get; set;}
		public byte[] COST_DESCR {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}