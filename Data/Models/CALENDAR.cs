using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class CALENDAR{
		public int CLNDR_ID {get; set;}
		public String DEFAULT_FLAG {get; set;}
		public String CLNDR_NAME {get; set;}
		public int PROJ_ID {get; set;}
		public int BASE_CLNDR_ID {get; set;}
		public DateTime LAST_CHNG_DATE {get; set;}
		public String CLNDR_TYPE {get; set;}
		public float DAY_HR_CNT {get; set;}
		public float WEEK_HR_CNT {get; set;}
		public float MONTH_HR_CNT {get; set;}
		public float YEAR_HR_CNT {get; set;}
		public String RSRC_PRIVATE {get; set;}
		public byte[] CLNDR_DATA {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}