using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PROJEST{
		public int PROJ_EST_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int RSRC_ID {get; set;}
		public int WBS_ID {get; set;}
		public String EST_NAME {get; set;}
		public float EST_QTY {get; set;}
		public DateTime EST_DATE {get; set;}
		public String EST_TYPE {get; set;}
		public String APPLIED_FLAG {get; set;}
		public int ADJ_MULT_PCT {get; set;}
		public int BU_CMPLX_VALUE {get; set;}
		public int EST_TASK_CNT {get; set;}
		public int FP_CMPLX_VALUE {get; set;}
		public int FP_CNT {get; set;}
		public float FP_PROD_AVG_VALUE {get; set;}
		public int FP_UNADJ_CNT {get; set;}
		public String RSRC_TYPE {get; set;}
		public byte[] EST_NOTES {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}