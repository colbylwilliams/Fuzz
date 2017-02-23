using System;
using System.Collections.Generic;
using Fuzz.Domain;
namespace Fuzz.Shared
{
	public class OtisClient
	{
		static OtisClient _shared;
		public static OtisClient Shared => _shared ?? (_shared = new OtisClient ());

		public List<Company> Companies { get; set; }

		OtisClient ()
		{
		}
	}
}
