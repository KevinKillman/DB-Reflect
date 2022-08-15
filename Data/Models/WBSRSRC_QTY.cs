using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class WBSRSRC_QTY{
		public int WBSRSRC_ID {get; set;}
		public DateTime WEEK_START {get; set;}
		public DateTime MONTH_START {get; set;}
		public float QTY {get; set;}
		public int FIN_DATES_ID1 {get; set;}
		public float FIN_QTY1 {get; set;}
		public int FIN_DATES_ID2 {get; set;}
		public float FIN_QTY2 {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}