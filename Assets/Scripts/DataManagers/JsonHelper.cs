﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class JsonHelper : MonoBehaviour
{    
    ShootersFest coconutShooter = new ShootersFest();

    public LevelStruct[] levels;

    string file = "leveldata.json";

    public void ReadData()
    {
        string path = Application.streamingAssetsPath + "/" + file;
        string jsonString;

        if (Application.platform == RuntimePlatform.Android)
        {
            var reader = new UnityWebRequest(path);
            reader.downloadHandler = new DownloadHandlerBuffer();
            while (!reader.downloadHandler.isDone) { }

            jsonString = reader.downloadHandler.text;
        }
        else
        {
            jsonString = File.ReadAllText(path);
        }
        coconutShooter = JsonUtility.FromJson<ShootersFest>(jsonString);
        levels = coconutShooter.levelData.levels;
    }

    public void SaveData()
    {
        //LevelData levelData= new LevelData();
        //coconutShooter.levelData = levelData;
        string path = Application.streamingAssetsPath + "/" + file;
        string content = JsonUtility.ToJson(coconutShooter, true);
        File.WriteAllText(path, content);
        Debug.Log(path);
    }
    
}