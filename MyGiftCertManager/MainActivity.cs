using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MyGiftCertManager
{
	[Activity (Label = "MyGiftCertManager", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
			ActionBar.Tab tab = ActionBar.NewTab ();
			tab.SetText (Resources.GetString (Resource.String.setting_tab_name));
			tab.SetIcon (Android.Resource.Drawable.IcMenuPreferences);
			tab.TabSelected += (sender, args) => {
				// Do something when tab is selected
			};
			this.ActionBar.AddTab (tab);

			tab = ActionBar.NewTab ();
			tab.SetText (Resources.GetString (Resource.String.company_tab_name));
			tab.SetIcon (Android.Resource.Drawable.IcMenuSave);
			tab.TabSelected += (sender, args) => {
				// Do something when tab is selected
			};
			ActionBar.AddTab (tab);

			tab = ActionBar.NewTab ();
			tab.SetText (Resources.GetString (Resource.String.order_tab_name));
			tab.SetIcon (Android.Resource.Drawable.IcMenuSearch);
			tab.TabSelected += (sender, args) => {
				// Do something when tab is selected
			};
			ActionBar.AddTab (tab);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}


