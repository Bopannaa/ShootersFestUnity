using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingPanel : MonoBehaviour
{
    public Slider slider;

    float sliderValue = 0.0f;

    public void Load(string name)
    {
        StartCoroutine(StartLoading(name));
    }

    IEnumerator StartLoading(string name)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(name);
        while (!operation.isDone)
        {
            sliderValue = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = sliderValue;
            yield return null;
        }
        sliderValue = 0.0f;
        transform.gameObject.SetActive(false);
    }
}