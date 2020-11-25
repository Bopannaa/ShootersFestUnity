using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class PlayPopup : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI levelDetailsText, currentLevelText;

    private string currentLevelName;

    private GameObject go;

    public static Action<string> ActionPlayButton;

    public void ResetLevelDetails(int level, int noOfTargets, float time)
    {
        currentLevelName = "Level" + level.ToString();
        levelDetailsText.text = "Targets: " + noOfTargets
            + "\n"
            + "Time: " + time;

        currentLevelText.text = "Level " + level.ToString();
    }

    public void OnPlayButtonClick()
    {
        if(ActionPlayButton != null)
        {
            ActionPlayButton(currentLevelName);
        }
    }
}
