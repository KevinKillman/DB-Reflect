using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class FACTOR{
		public int FACT_ID {get; set;}
		public int FACT_SEQ_NUM {get; set;}
		public String FACT_NAME {get; set;}
		public String FACT_TYPE {get; set;}
		public int DEF_FACT_VAL_ID {get; set;}
		public byte[] FACT_DESCR {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}