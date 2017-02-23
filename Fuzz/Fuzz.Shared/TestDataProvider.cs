using System;
using System.Linq;
using System.Threading.Tasks;

using ServiceStack;

using Fuzz.Domain;
using Fuzz.Shared;
using System.Collections.Generic;

namespace Fuzz
{
	public static class TestDataProvider
	{
#if __ANDROID__
		public static void InitTestDataAsync (Android.App.Activity context)
		{
			await Task.Delay (10);
#else
		public static void InitTestDataAsync ()
		{
#endif
			try
			{
				var name = "Fuzz-Companies";
#if __IOS__
				var path = Foundation.NSBundle.MainBundle.PathForResource (name, "json");

				using (var data = Foundation.NSData.FromFile (path))
				{
					var json = Foundation.NSString.FromData (data, Foundation.NSStringEncoding.ASCIIStringEncoding).ToString ();
#elif __ANDROID__
				var path = $"{name}.json";

				using (var sr = new System.IO.StreamReader (context.Assets.Open (path)))
				{
					var json = sr.ReadToEnd ();
#endif
					var companies = json?.FromJson<List<Company>> ();

					if (companies != null)
					{
						OtisClient.Shared.Companies = companies;
					}
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine ($"{ex.Message}");
			}
		}
	}
}