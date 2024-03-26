using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScene : MonoBehaviour
{
    private async void Awake()
    {
        await ScreenManager.Instance.OpenScreen(ScreenKeys.ProfileScreen, ScreenLayers.Background);
    }
}
