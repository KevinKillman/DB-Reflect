using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace UNKNOWNSPACE.Models
{
	public class IMAGEDATA{
		public int IMAGE_ID {get; set;}
		public String IMAGE_NAME {get; set;}
		public String DEFAULT_FLAG {get; set;}
		public byte[] IMAGE_THUMBNAIL {get; set;}
		public String IMAGE_PURPOSE {get; set;}
		public String IMAGE_DESCRIPTION {get; set;}
		public byte[] IMAGE_DATA {get; set;}
		public String IMAGE_EXTENSION {get; set;}
		public DateTime CREATE_DATE {get; set;}
		public String CREATE_USER {get; set;}
		public DateTime UPDATE_DATE {get; set;}
		public String UPDATE_USER {get; set;}
		public int DELETE_SESSION_ID {get; set;}
		public DateTime DELETE_DATE {get; set;}
		}}