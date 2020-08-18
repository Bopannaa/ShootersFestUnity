using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Scene_Manager : Singleton<Scene_Manager>
{   
    public Action CreatePersistableObjects; 

    void Start()
    {
        if(CreatePersistableObjects != null)
        {
            CreatePersistableObjects();
        }
    }

    public void OnEnable()
    {
        ShopScene.ActionBackButton  += LoadStartScene;
        StartScene.ActionShopButton += LoadShopScene;
        StartScene.ActionPlayButton += LoadLevelScene;
        LevelScene.ActionBackButton += LoadStartScene;
        LevelChooser.ActionLevelButton += LoadGameScene;
    }

    void OnDisable()
    {
        ShopScene.ActionBackButton  -= LoadStartScene;
        StartScene.ActionShopButton -= LoadShopScene;
        StartScene.ActionPlayButton -= LoadLevelScene;
        LevelScene.ActionBackButton -= LoadStartScene;
        LevelChooser.ActionLevelButton -= LoadGameScene;
    }

    public void LoadShopScene()
    {
        SceneManager.LoadScene("ShopScene");
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void LoadLevelScene()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}

