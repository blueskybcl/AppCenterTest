﻿
using Foundation;
using UIKit;

namespace AppCenterTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
#endif

            global::Xamarin.Forms.Forms.Init();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
