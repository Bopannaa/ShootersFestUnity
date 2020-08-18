﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

[System.Serializable]
public class LevelChooser : MonoBehaviour
{
    public static Action ActionLevelButton;

    [SerializeField] TextMeshProUGUI currentLevelText;
    [SerializeField] Slider starsSlider;
    [SerializeField] GameObject adUnlockButton;
    [SerializeField] Image image;

    public void Reset(int level, float stars, bool unlocked, Sprite sprite)
    {
        currentLevelText.text = level.ToString();
        starsSlider.value = stars;
        adUnlockButton.SetActive(!unlocked);
        image.sprite = sprite;
    }

    public void OnLevelButtonClick()
    {
        if(ActionLevelButton != null)
        {
            ActionLevelButton();
        }
    }
}
