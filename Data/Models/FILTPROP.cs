using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class FILTPROP{
		public int FILTER_ID {get; set;}
		public int USER_ID {get; set;}
		public String FILTER_TYPE {get; set;}
		public String FILTER_NAME {get; set;}
		public String TABLE_NAME {get; set;}
		public byte[] FILTER_DATA {get; set;}
		public int RPT_ID {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}