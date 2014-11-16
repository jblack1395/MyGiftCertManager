using System;

namespace MyGiftCardManagerShared
{
	public class MyGiftCardDAO
	{
		public MyGiftCardDAO ()
		{
		}
		public List<CompanyModel> retrieveCompanies() {
			var list = new List<CompanyModel> ();
			string url = "http://search.twitter.com/search.json?q=xamarin&rpp=10&include_entities=false&result_type=mixed";
			var httpReq = (HttpWebRequest)HttpWebRequest.Create (new Uri (url));
			httpReq.BeginGetResponse ((ar) => {
				var request = (HttpWebRequest)ar.AsyncState;
				using (var response = (HttpWebResponse)request.EndGetResponse (ar))     {                           
					var s = response.GetResponseStream ();
					var j = (JsonObject)JsonObject.Load (s);
					var results = (from result in (JsonArray)j ["results"]
						let jResult = result as JsonObject
						select jResult ["text"].ToString ()).ToArray ();
					RunOnUiThread (() => {
						ListAdapter = new ArrayAdapter<string> (this,
							Resource.Layout.TweetItemView, results);
					} );
				}
			} , httpReq);
			return list;
		}
	}
}

