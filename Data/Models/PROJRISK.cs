using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PROJRISK{
		public int RISK_ID {get; set;}
		public String RISK_CODE {get; set;}
		public int PROJ_ID {get; set;}
		public DateTime ADD_DATE {get; set;}
		public String STATUS_CODE {get; set;}
		public String RISK_NAME {get; set;}
		public int RISK_TYPE_ID {get; set;}
		public int RSRC_ID {get; set;}
		public String RISK_DESC {get; set;}
		public String RISK_TO_TYPE {get; set;}
		public int IDENTIFIED_BY_ID {get; set;}
		public String RESPONSE_TYPE {get; set;}
		public String RESPONSE_TEXT {get; set;}
		public String PRE_RSP_PRBLTY {get; set;}
		public String PRE_RSP_SCHD_PRBLTY {get; set;}
		public String PRE_RSP_COST_PRBLTY {get; set;}
		public String POST_RSP_PRBLTY {get; set;}
		public String POST_RSP_SCHD_PRBLTY {get; set;}
		public String POST_RSP_COST_PRBLTY {get; set;}
		public String RISK_CAUSE {get; set;}
		public String RISK_EFFECT {get; set;}
		public String NOTES {get; set;}
		public byte[] RISK_DESCR {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}