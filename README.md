# Intercom.Xamarin

## Introduction 
Xamarin Binding for Intercom 7.2.0.
The Intercom SDK enables you to use the Intercom Messenger in your app, have conversations with your customers, send rich outbound messages, show your Help Center, and track events.

## Installation

### Intercom packages
[Intercom.Xamarin.Android](https://www.nuget.org/packages/Intercom.Xamarin.Android/)

[Intercom.Xamarin.iOS](https://www.nuget.org/packages/Intercom.Xamarin.iOS/)

[Intercom.Xamarin.Forms](https://www.nuget.org/packages/Intercom.Xamarin.Forms/)


### Step 1 - Add refernces to Intercom
If you’re new to Intercom, you’ll need to create an account and start your free trial.

### Android

#### Permissions
We include the [INTERNET](https://developer.android.com/reference/android/Manifest.permission.html#INTERNET) permission by default as we need it to make network requests:

```
<uses-permission android:name="android.permission.INTERNET"/>
```

You will need to include the [READ_EXTERNAL_STORAGE](http://developer.android.com/reference/android/Manifest.permission.html#READ_EXTERNAL_STORAGE) permission if you have enabled image attachments:

```
<uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE"/>
```

You can also include [VIBRATE](https://developer.android.com/reference/android/Manifest.permission.html#VIBRATE) to enable vibration in push notifications:

```
<uses-permission android:name="android.permission.VIBRATE"/>
```

### iOS

#### Update Info.plist
**Photo Library usage:**
Add a "Privacy - Photo Library Usage Description" entry to your Info.plist.

This is [required by Apple](https://developer.apple.com/library/archive/qa/qa1937/_index.html) for all apps that access the photo library. It is necessary when installing Intercom due to the image upload functionality. Users will be prompted for the photo library permission only when they tap the image upload button.

### Step 2 - Initialize Intercom
First, you'll need to get your [Intercom](https://www.intercom.com/) **app ID** and **Android API key**. To find these, just select the **'Intercom for Android/iOS'** option in your app settings.


### Android
Then, initialize Intercom by calling the following in the `OnCreate()` method of your application class:

```
Intercom.Initialize(this, "your api key", "your app id");
```

**Note:** If you don't currently implement a custom application, you’ll need to create one. A custom application looks like this:

```
public class MainApplication : Application, Application.IActivityLifecycleCallbacks {
    public override void OnCreate()
        {
            base.OnCreate();
            Intercom.Initialize(this, "your api key", "your app id");
   }
}
```

You’ll need to update your manifest to use your application:


```
<application
    android:name=".MainApplication">
</application>
```

>Intercom must be initialized inside the application `OnCreate()` method. Initializing anywhere else will result in Intercom not behaving as expected and could even result in the host app crashing.

### iOS
Then, initialize Intercom by calling the following in the `FinishedLaunching()` method of your AppDelegate class:

```
Intercom.SetApiKey("your api key", "your app id");
```

### Forms
All the steps before are relevant in the "Forms", but you need to change your code like this:

#### Android
```
IntercomService.Initialize(this, "your api key", "your app id");
```

**Note:** If you don't currently implement a custom application, you’ll need to create one. A custom application looks like this:

```
public class MainApplication : Application, Application.IActivityLifecycleCallbacks {
    public override void OnCreate()
        {
            base.OnCreate();
            IntercomService.Initialize(this, "your api key", "your app id");
   }
}
```

You’ll need to update your manifest to use your application:


```
<application
    android:name=".MainApplication">
</application>
```

IntercomService must be initialized inside the application `OnCreate()` method. Initializing anywhere else will result in Intercom not behaving as expected and could even result in the host app crashing.

#### iOS
Then, initialize Intercom by calling the following in the `FinishedLaunching()` method of your AppDelegate class:

```
IntercomService.Initialize("your api key", "your app id");
```

### Step 3 - Create a user and display messenger
Finally, you’ll need to create a user, like this:

### Android
```
Registration registration = Registration.Create().WithUserId("123456");
Intercom.Client().RegisterIdentifiedUser(registration);
Intercom.Client().DisplayMessenger();
```

### iOS
```
Intercom.iOS.Intercom.SetApiKey("your api key", "your app id");
Intercom.iOS.Intercom.RegisterUnidentifiedUser();
Intercom.iOS.Intercom.PresentConversationList();
```

### Forms
Then, register user by calling the following in the OnAppearing()` method of your Page class:

```
CrossIntercomService.Current.RegisterUserWithUserId("123456");
CrossIntercomService.Current.PresentMessenger();
```

**Available methods:**
```
void EnableLogging();
void HandleIntercomPushNotification(Dictionary<string, string> userInfo);
void HideMessenger();
bool IsIntercomPushNotification(Dictionary<string, string> userInfo);
void LogEventWithName(string name);
void LogEventWithName(string name, Dictionary<string, string> metaData);
void Logout();
void PresentConversationList();
void PresentHelpCenter();
void PresentMessageComposer(string initialMessage);
void PresentMessageComposer();
void PresentMessageComposerWithInitialMessage(string message);
void PresentMessenger();
void RegisterUnidentifiedUser();
void RegisterUserWithEmail(string email);
void RegisterUserWithUserId(string userId, string email);
void RegisterUserWithUserId(string userId);
void Reset();
void SetBottomPadding(float bottomPadding);
void SetDeviceToken(string deviceToken);
void SetInAppMessagesVisible(bool visible);
void SetLauncherVisible(bool visible);
void SetNeedsStatusBarAppearanceUpdate();
void SetUserHash(string userHash);
```
>Use them in a cross-platform project.

That’s it - now you’ve got a working Intercom app. However, you’ll need to register your users before you can talk to them and track their activity in your app.

For more details, see [Intercom for Android](https://developers.intercom.com/installing-intercom/docs/android-installation) or [Intercom for iOS](https://developers.intercom.com/installing-intercom/docs/ios-installation).

## Changelog

### Version 7.1.0

### 📱 New Feature: Mobile Carousels 
 
Bring your best features. We'll bring the spotlight. Use Mobile Carousels to connect with app users at every touchpoint—show them around, provide support, and highlight features you know they'll love.

Mobile Carousels are a multi-screen message designed to feel right at home in your mobile app. 

* Rich multi-screen messages.
* Highly customizable, right inside Intercom.
* Request device permissions like push notifications, camera, location and more.
* Deep link into your app, open URLs, or start conversations in the Intercom Messenger.
* Target the right message to the right audience.
* A/B testing and control groups.
* Goal tracking.
* Schedule your Mobile Carousel with ease.

Upgrade to the latest version of the mobile SDK today to use the feature. No additional integration work required.

### [Learn more about Mobile Carousels](https://www.intercom.com/mobile-carousels)

<a href="https://product-education.wistia.com/medias/4y7for3aya " target="_blank"><img  src="https://user-images.githubusercontent.com/3185423/84791321-5581cf00-afea-11ea-848e-d29fbd657e10.png"></a>

![Carousel - Made for mobile - Red](https://user-images.githubusercontent.com/5046761/84787741-439e2d00-afe6-11ea-9ff8-a1ed7c4850d7.png)

![anrdroid_standard](https://user-images.githubusercontent.com/3185423/84802829-0b541a00-aff9-11ea-9e7f-1613e8d7d369.gif)

![Carousel - Permissions - Android - Yellow](https://user-images.githubusercontent.com/5046761/84787743-439e2d00-afe6-11ea-96fd-9aebd745fa18.png)


### 📱 Closed Conversations

The mobile SDK now respects the `prevent replies to closed conversations` setting if you have it enabled. The text composer will be disabled for closed conversations, and your users will be able to start a new conversation if they need to. The UI updates in real time as the conversation takes place.

![closed convo android](https://user-images.githubusercontent.com/5046761/84785550-8579a400-afe3-11ea-978d-49cba15cf54c.gif)

For more details, see [Intercom for Android changelog](https://github.com/intercom/intercom-android/blob/master/CHANGELOG.md) or [Intercom for iOS changelog](https://github.com/intercom/intercom-ios/blob/master/CHANGELOG.md).
