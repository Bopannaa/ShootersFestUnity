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

    [SerializeField] WinPopup winPopup;

    public void ShowNoCreditsPopup()
    {
        noCreditsPopup.gameObject.SetActive(true);
    }

    public void ShowPlayPopup(int level)
    {
        playPopup.gameObject.SetActive(true);
        playPopup.ResetLevelDetails(level);
    }

    public void ShowLoadingPanel(string sceneName)
    {
        loadingPanel.gameObject.SetActive(true);
        loadingPanel.Load(sceneName);
    }

    public void ShowWinPopup()
    {
        winPopup.gameObject.SetActive(true);
    }
}
