using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class PFOLIO{
		public int PFOLIO_ID {get; set;}
		public int USER_ID {get; set;}
		public String PFOLIO_TYPE {get; set;}
		public String PFOLIO_NAME {get; set;}
		public String PFOLIO_DESCR {get; set;}
		public String CLOSED_PROJ_FLAG {get; set;}
		public String WHATIF_PROJ_FLAG {get; set;}
		public byte[] PFOLIO_DATA {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}