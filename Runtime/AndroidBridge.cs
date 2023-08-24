using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CleverTapSDK;

public class AndroidBridge
{
    public static void ShowToast(string text, ToastDuration duration)
    {
        using (AndroidJavaClass player = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        using (AndroidJavaObject activity = player.GetStatic<AndroidJavaObject>("currentActivity"))
        using (AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast"))
        using (AndroidJavaObject toastObject = toastClass.CallStatic<AndroidJavaObject>("makeText", activity, text, (int)duration))
        {
            toastObject.Call("show");
        }
    }
}
