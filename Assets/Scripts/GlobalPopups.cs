using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPopups : MonoBehaviour
{
    void OnEnable()
    {
        LevelChooser.ActionNoCredit += ShowNoCreditsPopup;
        LevelChooser.ActionLevelButton += ShowPlayPopup;
        PlayPopup.ActionPlayButton += ShowLoadingPanel;
    }

    void OnDisable()
    {
        LevelChooser.ActionNoCredit -= ShowNoCreditsPopup;
        LevelChooser.ActionLevelButton -= ShowPlayPopup;
        PlayPopup.ActionPlayButton -= ShowLoadingPanel;
    }

    [SerializeField]
    private NoCreditsPopup noCreditsPopup;
    
    [SerializeField]
    PlayPopup playPopup;

    [SerializeField]
    LoadingPanel loadingPanel;

    public void ShowNoCreditsPopup()
    {
        noCreditsPopup.gameObject.SetActive(true);
    }

    public void ShowPlayPopup(int level, int noOfTargets, float time)
    {
        playPopup.gameObject.SetActive(true);
        playPopup.ResetLevelDetails(level, noOfTargets, time);
    }

    public void ShowLoadingPanel(string sceneName)
    {
        loadingPanel.gameObject.SetActive(true);
        loadingPanel.Load(sceneName);
    }
}
