using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class RSRC{
		public int RSRC_ID {get; set;}
		public int PARENT_RSRC_ID {get; set;}
		public int CLNDR_ID {get; set;}
		public int ROLE_ID {get; set;}
		public int SHIFT_ID {get; set;}
		public int USER_ID {get; set;}
		public int POBS_ID {get; set;}
		public String GUID {get; set;}
		public int RSRC_SEQ_NUM {get; set;}
		public String EMAIL_ADDR {get; set;}
		public String EMPLOYEE_CODE {get; set;}
		public String OFFICE_PHONE {get; set;}
		public String OTHER_PHONE {get; set;}
		public String RSRC_NAME {get; set;}
		public String RSRC_SHORT_NAME {get; set;}
		public String RSRC_TITLE_NAME {get; set;}
		public float DEF_QTY_PER_HR {get; set;}
		public String COST_QTY_TYPE {get; set;}
		public float OT_FACTOR {get; set;}
		public String ACTIVE_FLAG {get; set;}
		public String AUTO_COMPUTE_ACT_FLAG {get; set;}
		public String DEF_COST_QTY_LINK_FLAG {get; set;}
		public String OT_FLAG {get; set;}
		public int CURR_ID {get; set;}
		public int UNIT_ID {get; set;}
		public String RSRC_TYPE {get; set;}
		public int LOCATION_ID {get; set;}
		public byte[] RSRC_NOTES {get; set;}
		public String TIMESHEET_FLAG {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}