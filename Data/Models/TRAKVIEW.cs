using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class TRAKVIEW{
		public int TRACK_VIEW_ID {get; set;}
		public int USER_ID {get; set;}
		public String DISPLAY_TYPE {get; set;}
		public String TRACK_VIEW_NAME {get; set;}
		public String WEB_VIEW_FLAG {get; set;}
		public byte[] TRACK_VIEW_DATA {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}