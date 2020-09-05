using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameScene : MonoBehaviour
{
    public static Action ActionPauseButton;
    public static Action ActionShootButton;
    public static Action ActionSwapButton;

    void Start()
    {
        Game_Manager.Instance.ResetGame();
        Game_Manager.Instance.ResumeGame();
    }
    
    public void OnPauseButtonClick()
    {
        if(ActionPauseButton != null)
        {
            ActionPauseButton();
        }
    }
    
    public void OnShootButtonClick()
    {
        if(ActionShootButton != null)
        {
            ActionShootButton();
        }
    }
    
    public void OnSwapButtonClick()
    {
        if(ActionSwapButton != null)
        {
            ActionSwapButton();
        }
    }

    void OnDestroy()
    {
        Game_Manager.Instance.PauseGame();
        Game_Manager.Instance.ResetGame();
    }
}
