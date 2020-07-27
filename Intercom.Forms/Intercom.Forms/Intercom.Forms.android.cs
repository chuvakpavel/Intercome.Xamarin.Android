using IO.Intercom.Android.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Intercom.Forms
{
    /// <summary>
    /// Interface for Intercom.Forms
    /// </summary>
    public class IntercomService : IIntercomService
    {
        public static void Initialize(Android.App.Application application, string apiKey, string appId)
        {
            IO.Intercom.Android.Intercom.Initialize(application, apiKey, appId);
        }

        public void SetUserHash(string userHash)
        {
            IO.Intercom.Android.Intercom.Client().SetUserHash(userHash);
        }

        public void RegisterUnidentifiedUser()
        {
            IO.Intercom.Android.Intercom.Client().RegisterUnidentifiedUser();
        }

        public void RegisterUserWithEmail(string email)
        {
            IO.Intercom.Android.Intercom.Client().RegisterIdentifiedUser(new Registration().WithEmail(email));
        }

        public void RegisterUserWithUserId(string userId)
        {
            IO.Intercom.Android.Intercom.Client().RegisterIdentifiedUser(new Registration().WithUserId(userId));
        }

        public void RegisterUserWithUserId(string userId, string email)
        {
            IO.Intercom.Android.Intercom.Client().RegisterIdentifiedUser(new Registration().WithUserId(userId).WithEmail(email));
        }

        public void Logout()
        {
            IO.Intercom.Android.Intercom.Client().Logout();
        }

        public void Reset()
        {
            IO.Intercom.Android.Intercom.Client().Reset();
        }

        public void LogEventWithName(string name)
        {
            IO.Intercom.Android.Intercom.Client().LogEvent(name);
        }

        public void LogEventWithName(string name, Dictionary<string, string> metaData)
        {
            var androidMetaData = metaData.ToDictionary(pair => pair.Key, pair => (object)pair.Value);

            IO.Intercom.Android.Intercom.Client().LogEvent(name, androidMetaData);
        }

        public void PresentMessenger()
        {
            IO.Intercom.Android.Intercom.Client().DisplayMessenger();
        }

        public void PresentMessageComposer(string initialMessage)
        {
            IO.Intercom.Android.Intercom.Client().DisplayMessageComposer(initialMessage);
        }

        public void PresentMessageComposer()
        {
            IO.Intercom.Android.Intercom.Client().DisplayMessageComposer();
        }

        public void PresentMessageComposerWithInitialMessage(string message)
        {
            IO.Intercom.Android.Intercom.Client().DisplayMessageComposer(message);
        }

        public void PresentConversationList()
        {
            IO.Intercom.Android.Intercom.Client().DisplayConversationsList();
        }

        public void PresentHelpCenter()
        {
            IO.Intercom.Android.Intercom.Client().DisplayHelpCenter();
        }

        public void SetDeviceToken(string deviceToken)
        {
            throw new NotImplementedException();
        }

        public bool IsIntercomPushNotification(Dictionary<string, string> userInfo)
        {
            throw new NotImplementedException();
        }

        public void HandleIntercomPushNotification(Dictionary<string, string> userInfo)
        {
            throw new NotImplementedException();
        }

        public void SetBottomPadding(float bottomPadding)
        {
            IO.Intercom.Android.Intercom.Client().SetBottomPadding((int)bottomPadding);
        }

        public void SetInAppMessagesVisible(bool visible)
        {
            var visibility = visible ? IO.Intercom.Android.Intercom.Visibility.Visible : IO.Intercom.Android.Intercom.Visibility.Gone;

            IO.Intercom.Android.Intercom.Client().SetInAppMessageVisibility(visibility);
        }

        public void SetLauncherVisible(bool visible)
        {
            var visibility = visible ? IO.Intercom.Android.Intercom.Visibility.Visible : IO.Intercom.Android.Intercom.Visibility.Gone;

            IO.Intercom.Android.Intercom.Client().SetLauncherVisibility(visibility);
        }

        public void HideMessenger()
        {
            IO.Intercom.Android.Intercom.Client().HideMessenger();
        }

        public void EnableLogging()
        {
            IO.Intercom.Android.Intercom.Client().HideMessenger();
        }

        public void SetNeedsStatusBarAppearanceUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
