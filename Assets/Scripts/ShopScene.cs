using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShopScene : MonoBehaviour
{
    public static Action ActionBackButton;
    public static Action ActionNextGunButton;
    public static Action ActionPreviousGunButton;
    
    public  void OnBackButtonClick()
    {
        if(ActionBackButton != null)
        {
            ActionBackButton();
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
