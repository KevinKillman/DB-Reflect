using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class RCATTYPE{
		public int RSRC_CATG_TYPE_ID {get; set;}
		public int SEQ_NUM {get; set;}
		public int RSRC_CATG_SHORT_LEN {get; set;}
		public String RSRC_CATG_TYPE {get; set;}
		public String SUPER_FLAG {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}