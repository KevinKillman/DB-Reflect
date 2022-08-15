using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class ROLERATE{
		public int ROLE_RATE_ID {get; set;}
		public int ROLE_ID {get; set;}
		public float COST_PER_QTY {get; set;}
		public float COST_PER_QTY2 {get; set;}
		public float COST_PER_QTY3 {get; set;}
		public float COST_PER_QTY4 {get; set;}
		public float COST_PER_QTY5 {get; set;}
		public DateTime START_DATE {get; set;}
		public float MAX_QTY_PER_HR {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}