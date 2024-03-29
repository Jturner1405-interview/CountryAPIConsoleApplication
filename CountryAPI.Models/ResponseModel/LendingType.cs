﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
	/// <summary>
	/// Lending Type Model
	/// </summary>
	[JsonObject("lendingType")]
	public class LendingType
	{
		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("iso2code")]
		public string Iso2code { get; set; }

		[JsonPropertyName("value")]
		public string Value { get; set; }
	}
}
