# Intercom.Xamarin

## Introduction 
Xamarin Binding for Intercom 6.1.0.
The Intercom SDK enables you to use the Intercom Messenger in your app, have conversations with your customers, send rich outbound messages, show your Help Center, and track events.

## Installation

### Intercom packages
[Intercom.Xamarin.Android](https://www.nuget.org/packages/Intercom.Xamarin.Android/6.1.0)
[Intercom.Xamarin.iOS](https://www.nuget.org/packages/Intercom.Xamarin.iOS/)

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
Then, initialize Intercom by calling the following in the `onCreate()` method of your application class:

```
Intercom.initialize(this, "your api key", "your app id");
```

**Note:** If you don't currently implement a custom application, you’ll need to create one. A custom application looks like this:

```
public class CustomApplication extends Application {
    @Override public void onCreate() {
        super.onCreate();
        Intercom.initialize(this, "your api key", "your app id");
   }
}
```

You’ll need to update your manifest to use your application:


```
<application
    android:name=".CustomApplication">
</application>
```

>Intercom must be initialized inside the application `onCreate()` method. Initializing anywhere else will result in Intercom not behaving as expected and could even result in the host app crashing.

### iOS
Then, initialize Intercom by calling the following in the `FinishedLaunching()` method of your AppDelegate class:

```
Intercom.SetApiKey("your api key", "your app id");
```

### Forms
All the steps before are relevant in the "Forms", but you need to change your code like this:

#### Android
```
Intercom.Forms.IntercomService.Initialize(this, "your api key", "your app id");
```

#### iOS
```
Intercom.Forms.IntercomService.Initialize("your api key", "your app id");
```

### Step 3 - Create a user
Finally, you’ll need to create a user, like this:

### Android
```
Registration registration = Registration.create().withUserId("123456");
Intercom.client().registerIdentifiedUser(registration);
```

### iOS
```
Intercom.iOS.Intercom.RegisterUnidentifiedUser();
```

### Forms

#### Android
```
Intercom.Forms.IntercomService service = new Intercom.Forms.IntercomService();
service.RegisterUnidentifiedUser();
```

#### iOS
```
Intercom.Forms.IntercomService service = new Intercom.Forms.IntercomService();
service.RegisterUnidentifiedUser();
```

That’s it - now you’ve got a working Intercom app. However, you’ll need to register your users before you can talk to them and track their activity in your app.

For more details, see [Intercom for Android](https://developers.intercom.com/installing-intercom/docs/android-installation) or [Intercom for iOS](https://developers.intercom.com/installing-intercom/docs/ios-installation).