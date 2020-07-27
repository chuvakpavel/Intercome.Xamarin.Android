using System;
using System.Collections.Generic;
using System.Text;

namespace Intercom.Forms
{
    public interface IIntercomService
    {
        void SetUserHash(string userHash);

        void RegisterUnidentifiedUser();

        void RegisterUserWithEmail(string email);

        void RegisterUserWithUserId(string userId);

        void RegisterUserWithUserId(string userId, string email);

        void Logout();

        void Reset();

        //void UpdateUser(Intercom.iOS.ICMUserAttributes userAttributes);

        void LogEventWithName(string name);

        void LogEventWithName(string name, Dictionary<string, string> metaData);

        void PresentMessenger();

        void PresentMessageComposer(string initialMessage);

        void PresentMessageComposer();

        void PresentMessageComposerWithInitialMessage(string message);

        void PresentConversationList();

        void PresentHelpCenter();

        void SetDeviceToken(string deviceToken);

        bool IsIntercomPushNotification(Dictionary<string, string> userInfo);

        void HandleIntercomPushNotification(Dictionary<string, string> userInfo);

        void SetBottomPadding(float bottomPadding);

        void SetInAppMessagesVisible(bool visible);

        void SetLauncherVisible(bool visible);

        void HideMessenger();

        //nuint UnreadConversationCount { get; }

        void EnableLogging();

        void SetNeedsStatusBarAppearanceUpdate();
    }
}
