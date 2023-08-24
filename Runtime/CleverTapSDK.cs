using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleverTapSDK
{
    #region Public declarations
    public enum ToastDuration
    {
        Short = 0,
        Long = 1
    }
    #endregion

    #region Public functions
    public static void ShowToast(string text, ToastDuration duration)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidBridge.ShowToast(text, duration);
        }
    }
    #endregion
}
