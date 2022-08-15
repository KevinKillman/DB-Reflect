using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class ADMIN_CONFIG{
		public String CONFIG_NAME {get; set;}
		public String CONFIG_TYPE {get; set;}
		public String FACTORY_VERSION {get; set;}
		public DateTime LAST_CHANGE_DATE {get; set;}
		public String CONFIG_VALUE {get; set;}
		public byte[] CONFIG_DATA {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}