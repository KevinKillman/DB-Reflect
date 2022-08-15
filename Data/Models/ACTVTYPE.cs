using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class ACTVTYPE{
		public int ACTV_CODE_TYPE_ID {get; set;}
		public int ACTV_SHORT_LEN {get; set;}
		public int SEQ_NUM {get; set;}
		public String ACTV_CODE_TYPE {get; set;}
		public int PROJ_ID {get; set;}
		public String SUPER_FLAG {get; set;}
		public String ACTV_CODE_TYPE_SCOPE {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}