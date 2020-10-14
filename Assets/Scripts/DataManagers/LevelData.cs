﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData
{
    public LevelStruct[] levels = new LevelStruct[7];

    public LevelData()
    {
        for (int i = 0; i < levels.Length; i++)
        {
            int temp = i + 1;
            levels[i] = new LevelStruct("Level: " + temp, i + 2, i + 5, 0);
        }
    }
    
}

[System.Serializable]
public class LevelStruct
{
    public string name = "";
    public float time = 0.0f;
    public int targetCount = 0;
    public int bulletsCount = 0;

    public LevelStruct(string name, float time, int targetCount, int bulletsCount)
    {
        this.name = name;
        this.time = time;
        this.targetCount = targetCount;
        this.bulletsCount = bulletsCount;
    }
}