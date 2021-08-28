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
    Game_Manager game_Manager;

    private GameObject go;

    public static Action<string> ActionPlayButton;

    void Awake()
    {
        game_Manager = Game_Manager.Instance;
    }

    public void ResetLevelDetails(int level)
    {
        game_Manager.currentLevel = level - 1;
        currentLevelName = "Level" + level.ToString();
        levelDetailsText.text = "Targets: " + game_Manager.levelHelper.levels[level - 1].targetCount
            + "\n"
            + "Time: " + game_Manager.levelHelper.levels[level - 1].time;
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
