using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace IntercomTest.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        // class-level declarations

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Intercom.iOS.Intercom.SetApiKey("your api key", "your app id");

            Intercom.iOS.Intercom.RegisterUnidentifiedUser();
            Intercom.iOS.Intercom.PresentConversationList();

            return true;
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, UIWindow forWindow)
        {
            return UIInterfaceOrientationMask.Portrait;
        }
    }
}
