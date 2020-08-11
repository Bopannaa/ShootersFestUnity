using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StartScene : MonoBehaviour
{
    public static Action ActionPlayButton;
    public static Action ActionShareButton;
    public static Action ActionRateButton;
    public static Action ActionShopButton;
    public static Action ActionSettingsButton;
    public static Action ActionQuitButton;
    public static Action ActionWatchAdButton;
    
    public  void OnPlayButtonClick()
    {
        if(ActionPlayButton != null)
        {
            ActionPlayButton();
        }
    }
    
    public  void OnShareButtonClick()
    {
        if(ActionShareButton != null)
        {
            ActionShareButton();
        }
    }
    
    public  void OnRateButtonClick()
    {
        if(ActionRateButton != null)
        {
            ActionRateButton();
        }
    }
    
    public  void OnShopButtonClick()
    {
        if(ActionShopButton != null)
        {
            ActionShopButton();
        }
    }
    
    public  void OnSettingsButtonClick()
    {
        if(ActionSettingsButton != null)
        {
            ActionSettingsButton();
        }
    }
    
    public  void OnQuitButtonClick()
    {
        if(ActionQuitButton != null)
        {
            ActionQuitButton();
        }
    }

}
