using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class USERCOL{
		public int USER_COL_ID {get; set;}
		public String TABLE_NAME {get; set;}
		public String LOGICAL_DATA_TYPE {get; set;}
		public String USER_COL_NAME {get; set;}
		public String USER_COL_LABEL {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}