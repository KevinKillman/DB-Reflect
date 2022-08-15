using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class JOBSVC{
		public int JOB_ID {get; set;}
		public int PARENT_JOB_ID {get; set;}
		public int SEQ_NUM {get; set;}
		public String AUDIT_FLAG {get; set;}
		public String JOB_TYPE {get; set;}
		public String JOB_NAME {get; set;}
		public int USER_ID {get; set;}
		public DateTime LAST_RUN_DATE {get; set;}
		public String STATUS_CODE {get; set;}
		public String RECUR_DATA {get; set;}
		public String RECUR_TYPE {get; set;}
		public String LAST_ERROR_DESCR {get; set;}
		public DateTime SUBMITTED_DATE {get; set;}
		public String AUDIT_FILE_PATH {get; set;}
		public byte[] JOB_DATA {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}