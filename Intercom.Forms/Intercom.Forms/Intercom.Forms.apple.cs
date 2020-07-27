using System;
using System.Collections.Generic;
using Foundation;
using System.Linq;

namespace Intercom.Forms
{
    /// <summary>
    /// Interface for Intercom.Forms
    /// </summary>
    public class IntercomService : IIntercomService
    {
        public static void Initialize(string apiKey, string appId)
        {
            Intercom.iOS.Intercom.SetApiKey(apiKey, appId);
        }

        public void SetUserHash(string userHash)
        {
            Intercom.iOS.Intercom.SetUserHash(userHash);
        }

        public void RegisterUnidentifiedUser()
        {
            Intercom.iOS.Intercom.RegisterUnidentifiedUser();
        }

        public void RegisterUserWithEmail(string email)
        {
            Intercom.iOS.Intercom.RegisterUserWithEmail(email);
        }

        public void RegisterUserWithUserId(string userId)
        {
            Intercom.iOS.Intercom.RegisterUserWithUserId(userId);
        }

        public void RegisterUserWithUserId(string userId, string email)
        {
            Intercom.iOS.Intercom.RegisterUserWithUserId(userId, email);
        }

        public void Logout()
        {
            Intercom.iOS.Intercom.Logout();
        }

        public void Reset()
        {
            Intercom.iOS.Intercom.Reset();
        }

        //public void UpdateUser(Intercom.iOS.ICMUserAttributes userAttributes)
        //{
        //    Intercom.iOS.Intercom.UpdateUser(userAttributes);
        //}

        public void LogEventWithName(string name)
        {
            Intercom.iOS.Intercom.LogEventWithName(name);
        }

        public void LogEventWithName(string name, Dictionary<string, string> metaData)
        {
            var nsMetaData = NSDictionary.FromObjectsAndKeys(metaData.Values.ToArray(), metaData.Keys.ToArray());

            Intercom.iOS.Intercom.LogEventWithName(name, nsMetaData);
        }

        public void PresentMessenger()
        {
            Intercom.iOS.Intercom.PresentMessenger();
        }

        public void PresentMessageComposer(string initialMessage)
        {
            Intercom.iOS.Intercom.PresentMessageComposer(initialMessage);
        }

        public void PresentMessageComposer()
        {
            Intercom.iOS.Intercom.PresentMessageComposer();
        }

        public void PresentMessageComposerWithInitialMessage(string message)
        {
            Intercom.iOS.Intercom.PresentMessageComposerWithInitialMessage(message);
        }

        public void PresentConversationList()
        {
            Intercom.iOS.Intercom.PresentConversationList();
        }

        public void PresentHelpCenter()
        {
            Intercom.iOS.Intercom.PresentHelpCenter();
        }

        public void SetDeviceToken(string deviceToken)
        {
            var nsDeviceToken = NSData.FromString(deviceToken);

            Intercom.iOS.Intercom.SetDeviceToken(nsDeviceToken);
        }

        public bool IsIntercomPushNotification(Dictionary<string, string> userInfo)
        {
            var nsUserInfo = NSDictionary.FromObjectsAndKeys(userInfo.Values.ToArray(), userInfo.Keys.ToArray());

            return Intercom.iOS.Intercom.IsIntercomPushNotification(nsUserInfo);
        }

        public void HandleIntercomPushNotification(Dictionary<string, string> userInfo)
        {
            var nsUserInfo = NSDictionary.FromObjectsAndKeys(userInfo.Values.ToArray(), userInfo.Keys.ToArray());

            Intercom.iOS.Intercom.HandleIntercomPushNotification(nsUserInfo);
        }

        public void SetBottomPadding(float bottomPadding)
        {
            Intercom.iOS.Intercom.SetBottomPadding(bottomPadding);
        }

        public void SetInAppMessagesVisible(bool visible)
        {
            Intercom.iOS.Intercom.SetInAppMessagesVisible(visible);
        }

        public void SetLauncherVisible(bool visible)
        {
            Intercom.iOS.Intercom.SetLauncherVisible(visible);
        }

        public void HideMessenger()
        {
            Intercom.iOS.Intercom.HideMessenger();
        }

        nuint UnreadConversationCount { get; }

        public void EnableLogging()
        {
            Intercom.iOS.Intercom.EnableLogging();
        }

        public void SetNeedsStatusBarAppearanceUpdate()
        {
            Intercom.iOS.Intercom.SetNeedsStatusBarAppearanceUpdate();
        }
    }
}
