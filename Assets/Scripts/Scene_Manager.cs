using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Scene_Manager : Singleton<Scene_Manager>
{
    public Action CreatePersistableObjects;

    public InputControl inputControl;
    public GlobalPopups globalPopups;

    void Start()
    {
        if (CreatePersistableObjects != null)
        {
            CreatePersistableObjects();
        }
    }

    void Awake()
    {
        inputControl = new InputControl();
    }

    public void OnEnable()
    {
        StartScene.ActionQuitButton += QuitGame;
        StartScene.ActionShopButton += LoadScene;
        StartScene.ActionPlayButton += LoadScene;
        ShopScene.ActionBackButton  += LoadScene;
        LevelScene.ActionBackButton += LoadScene;

        //LevelChooser.ActionLevelButton += LoadGameScene;

        //GameScene.ActionPauseButton += LoadStartScene; // to be removed

        inputControl.Enable();
    }

    void OnDisable()
    {
        StartScene.ActionQuitButton -= QuitGame;
        StartScene.ActionShopButton -= LoadScene;
        StartScene.ActionPlayButton -= LoadScene;
        LevelScene.ActionBackButton -= LoadScene;
        ShopScene.ActionBackButton  -= LoadScene;

        //LevelChooser.ActionLevelButton -= LoadGameScene;


        //GameScene.ActionPauseButton -= LoadStartScene; // to be removed
        
        inputControl.Disable();
    }

    public void LoadScene(string name)
    {
        globalPopups.ShowLoadingPanel(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

