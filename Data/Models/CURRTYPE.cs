using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class CURRTYPE{
		public int CURR_ID {get; set;}
		public int DECIMAL_DIGIT_CNT {get; set;}
		public String CURR_SYMBOL {get; set;}
		public String DECIMAL_SYMBOL {get; set;}
		public String DIGIT_GROUP_SYMBOL {get; set;}
		public String POS_CURR_FMT_TYPE {get; set;}
		public String NEG_CURR_FMT_TYPE {get; set;}
		public String CURR_TYPE {get; set;}
		public String CURR_SHORT_NAME {get; set;}
		public int GROUP_DIGIT_CNT {get; set;}
		public float BASE_EXCH_RATE {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}