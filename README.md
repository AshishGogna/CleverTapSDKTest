# CleverTap SDK Test Package

This SDK provides a way to show toast messages on Android.

Requirements of the SDK were to create a GameObject which can be used by the weather app, upon clicking which, a Toast containing the temperature will be shown. 

But, the SDK does not need to have a GameObject to be able to show toasts, so only the necessary code files are exported through the package. CleverTapSDK.ShowToast function can be called from the weather app to show the toast.

Example code to show toast: 
```
CleverTapSDK.ShowToast("Crispy toast", ToastDuration.Short);
```

## Documentation

### class CleverTapSDK

#### enum ToastDuration
Short (Equivalent to Android's Toast.LENGTH_SHORT)

Long (Equivalent to Android's Toast.LENGTH_LONG)

#### Methods
ShowToast(string text, ToastDuration duration)
Shows a toast when the runtime environment is Android.

## Install

#### Through [Unity Package Manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html)

Unity's own Package Manager supports [importing packages through a URL to a Git repo](https://docs.unity3d.com/Manual/upm-ui-giturl.html):

1. First, on this repository page, click the "Clone or download" button, and copy over this repository's HTTPS URL.  
2. Then click on the + button on the upper-left-hand corner of the Package Manager, select "Add package from git URL..." on the context menu, then paste this repo's URL!

While easier to follow than the first method, this one does not support dependency resolution and package upgrading when a new version is released.  So proceed with caution.

#### Through .zip file

1. Download this respository as a .zip file
2. Unzip
3. Then click on the + button on the upper-left-hand corner of the Package Manager, select "Add package from disk" on the context menu, then select the package.json file which is inside the extracted folder.
