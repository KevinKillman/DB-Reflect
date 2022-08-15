using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PCATVAL{
		public int PROJ_CATG_ID {get; set;}
		public int PROJ_CATG_TYPE_ID {get; set;}
		public int SEQ_NUM {get; set;}
		public String PROJ_CATG_SHORT_NAME {get; set;}
		public int PARENT_PROJ_CATG_ID {get; set;}
		public String PROJ_CATG_NAME {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}