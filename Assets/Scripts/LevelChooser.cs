﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

[System.Serializable]
public class LevelChooser : MonoBehaviour
{
    public static Action<int, int, float> ActionLevelButton;
    public static Action ActionNoCredit;

    [SerializeField] TextMeshProUGUI currentLevelText;
    [SerializeField] Slider starsSlider;
    [SerializeField] GameObject adUnlockButton;
    [SerializeField] Image image;

    public int Level { get; private set;}

    public void Reset(int level, float stars, bool unlocked, Sprite sprite)
    {
        currentLevelText.text = level.ToString();
        Level = level;
        starsSlider.value = stars;
        adUnlockButton.SetActive(!unlocked);
        image.sprite = sprite;
    }

    public void OnLevelButtonClick()
    {
        if (PersistentStorage.Instance.coins > 0)
        {
            if (ActionLevelButton != null)
            {
                ActionLevelButton(Level, 10, 5.6f);
            }
        }
        else
        {
            if (ActionNoCredit != null)
            {
                ActionNoCredit();
            }
        }

    }
}
