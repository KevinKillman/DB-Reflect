using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class ROLES{
		public int ROLE_ID {get; set;}
		public int PARENT_ROLE_ID {get; set;}
		public int SEQ_NUM {get; set;}
		public String ROLE_NAME {get; set;}
		public String ROLE_SHORT_NAME {get; set;}
		public int POBS_ID {get; set;}
		public String DEF_COST_QTY_LINK_FLAG {get; set;}
		public String COST_QTY_TYPE {get; set;}
		public byte[] ROLE_DESCR {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}