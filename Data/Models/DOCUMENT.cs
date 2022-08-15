using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class DOCUMENT{
		public int DOC_ID {get; set;}
		public int DOC_SEQ_NUM {get; set;}
		public String DELIV_FLAG {get; set;}
		public String DOC_NAME {get; set;}
		public int PARENT_DOC_ID {get; set;}
		public int PROJ_ID {get; set;}
		public int DOC_STATUS_ID {get; set;}
		public int DOC_CATG_ID {get; set;}
		public DateTime DOC_DATE {get; set;}
		public String VERSION_NAME {get; set;}
		public String GUID {get; set;}
		public String TMPL_GUID {get; set;}
		public String DOC_SHORT_NAME {get; set;}
		public String AUTHOR_NAME {get; set;}
		public String PRIVATE_LOC {get; set;}
		public String PUBLIC_LOC {get; set;}
		public String DOC_MGMT_TYPE {get; set;}
		public String CR_EXTERNAL_DOC_KEY {get; set;}
		public byte[] DOC_CONTENT {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}