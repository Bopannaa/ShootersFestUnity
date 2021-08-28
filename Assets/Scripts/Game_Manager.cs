using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Game_Manager : Singleton<Game_Manager>
{
    public Action ActionPauseGame;
    public Action ActionResumeGame;
    public Action ActionResetGame;
    public Action ActionLooseGame;
    public Action ActionWinGame;

    public Action<int> ActionSetTargetValue;
    public Action<float> ActionSetTimeValue;

    public JsonHelper levelHelper;

    public int currentLevel = 0;

    void OnEnable()
    {

    }

    void OnDisable()
    {

    }

    void Awake()
    {
        levelHelper = new JsonHelper();
        levelHelper.ReadData();
    }

    public void StartGame()
    {
        Debug.Log(currentLevel.ToString());
        if (ActionSetTargetValue != null)
        {
            ActionSetTargetValue(levelHelper.levels[currentLevel].targetCount);
        }
        if (ActionSetTimeValue != null)
        {
            ActionSetTimeValue(levelHelper.levels[currentLevel].time);
        }
        StartCoroutine(RunTimer());
    }

    void Update()
    {

    }

    public void ResumeGame()
    {
        if (ActionResumeGame != null)
        {
            ActionResumeGame();
        }
    }

    public void PauseGame()
    {
        if (ActionPauseGame != null)
        {
            ActionPauseGame();
        }
    }

    public void ResetGame()
    {
        if (ActionResetGame != null)
        {
            ActionResetGame();
        }

    }

    void CreateLevelData(int level)
    {
        currentLevel = level;
    }

    IEnumerator RunTimer()
    {
        float timeRemaining = levelHelper.levels[currentLevel].time;
        float currentTime = 0.0f;
        while (currentTime < timeRemaining)
        {
            currentTime++;
            if (ActionSetTimeValue != null)
            {
                ActionSetTimeValue(timeRemaining - currentTime);
            }
            yield return new WaitForSeconds(1);
        }
        if(ActionLooseGame != null)
        {
            ActionLooseGame();
        }
    }
}
