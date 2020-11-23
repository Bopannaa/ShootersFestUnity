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

    private int currentLevel;

    private GameObject go;

    public void ResetLevelDetails(int level, int noOfTargets, float time)
    {
        currentLevel = level;
        levelDetailsText.text = "Targets: " + noOfTargets
            + "\n"
            + "Time: " + time;

        currentLevelText.text = "Level " + level;
    }

    public void OnPlayButtonClick()
    {
        var levelName = "Level" + currentLevel.ToString();
        SceneManager.LoadScene(levelName);
    }
}
