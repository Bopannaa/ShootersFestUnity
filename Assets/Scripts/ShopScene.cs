using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShopScene : MonoBehaviour
{
    public static Action<string> ActionBackButton;
    public static Action ActionNextGunButton;
    public static Action ActionPreviousGunButton;
    
    public  void OnBackButtonClick()
    {
        if(ActionBackButton != null)
        {
            ActionBackButton("StartScene");
        }
    }
    
    public  void OnNextGunButtonClick()
    {
        if(ActionNextGunButton != null)
        {
            ActionNextGunButton();
        }
    }
    
    public  void OnPreviousGunButtonClick()
    {
        if(ActionPreviousGunButton != null)
        {
            ActionPreviousGunButton();
        }
    }
}
