using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Game_Manager : Singleton<Game_Manager>
{
    public Action ActionPauseGame;
    public Action ActionResumeGame;
    public Action ActionResetGame;
    public Action<int> ActionCreateLevel;

    void OnEnable()
    {

    }

    void OnDisable()
    {

    }

    void Start()
    {
    }

    void Update()
    {
        
    }

    public void ResumeGame()
    {
        if(ActionResumeGame != null)
        {
            ActionResumeGame();
        }
    }

    public void PauseGame()
    {
        if(ActionPauseGame != null)
        {
            ActionPauseGame();
        }
    }

    public void ResetGame()
    {
        if(ActionResetGame != null)
        {
            ActionResetGame();
        }
    }

    public void CreateLevel(int level)
    {
        if(ActionCreateLevel != null)
        {
            ActionCreateLevel(level);
        }
    }
}
