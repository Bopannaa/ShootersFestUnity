using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Scene_Manager : Singleton<Scene_Manager>
{   
    public void OnEnable()
    {
        ShopScene.ActionBackButton  += LoadStartScene;
        StartScene.ActionShopButton += LoadShopScene;
        StartScene.ActionPlayButton += LoadLevelScene;
        LevelScene.ActionBackButton += LoadStartScene;
    }

    void OnDisable()
    {
        ShopScene.ActionBackButton  -= LoadStartScene;
        StartScene.ActionShopButton -= LoadShopScene;
        StartScene.ActionPlayButton -= LoadLevelScene;
        LevelScene.ActionBackButton -= LoadStartScene;
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
}

