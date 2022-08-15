using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PROJISSU{
		public int ISSUE_ID {get; set;}
		public int OBS_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int RSRC_ID {get; set;}
		public int TASK_ID {get; set;}
		public int THRESH_ID {get; set;}
		public int THRESH_PARM_ID {get; set;}
		public int TRACK_VIEW_ID {get; set;}
		public int WBS_ID {get; set;}
		public String ADD_BY_NAME {get; set;}
		public String ISSUE_NAME {get; set;}
		public DateTime RESOLV_DATE {get; set;}
		public DateTime ADD_DATE {get; set;}
		public String PRIORITY_TYPE {get; set;}
		public String STATUS_CODE {get; set;}
		public int BASE_PROJ_ID {get; set;}
		public float HI_PARM_VALUE {get; set;}
		public float ISSUE_VALUE {get; set;}
		public float LO_PARM_VALUE {get; set;}
		public int WORKSPACE_ID {get; set;}
		public byte[] ISSUE_NOTES {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}