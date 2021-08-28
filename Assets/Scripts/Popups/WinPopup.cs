using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WinPopup : MonoBehaviour
{
    public static Action ActionNextButton;
    public static Action ActionReplayButton;
    public static Action ActionExitButton;

    public void OnNextButtonClick()
    {
        if (ActionNextButton != null)
        {
            ActionNextButton();
        }
    }

    public void OnReplayButtonClick()
    {
        if (ActionReplayButton != null)
        {
            ActionReplayButton();
        }
    }

    public void OnExitButtonClick()
    {
        if (ActionExitButton != null)
        {
            ActionExitButton();
        }
    }


}
