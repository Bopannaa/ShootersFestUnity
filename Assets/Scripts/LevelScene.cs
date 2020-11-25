using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelScene : MonoBehaviour
{
    public static Action<string> ActionBackButton;
    public static Action ActionNextChapterButton;
    public static Action ActionPreviousChapterButton;
    
    public  void OnBackButtonClick()
    {
        if(ActionBackButton != null)
        {
            ActionBackButton("StartScene");
        }
    }
    
    public  void OnNextChapterButtonClick()
    {
        if(ActionNextChapterButton != null)
        {
            ActionNextChapterButton();
        }
    }
    
    public  void OnPreviousChapterButtonClick()
    {
        if(ActionPreviousChapterButton != null)
        {
            ActionPreviousChapterButton();
        }
    }
}
