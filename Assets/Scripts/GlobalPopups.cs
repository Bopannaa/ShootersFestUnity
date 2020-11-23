using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPopups : MonoBehaviour
{
    void OnEnable()
    {
        LevelChooser.ActionNoCredit += ShowNoCreditsPopup;
        LevelChooser.ActionLevelButton += ShowPlayPopup;
    }

    void OnDisable()
    {
        LevelChooser.ActionNoCredit -= ShowNoCreditsPopup;
        LevelChooser.ActionLevelButton -= ShowPlayPopup;
    }

    [SerializeField]
    private NoCreditsPopup noCreditsPopup;
    
    [SerializeField]
    PlayPopup playPopup;

    void ShowNoCreditsPopup()
    {
        noCreditsPopup.gameObject.SetActive(true);
    }

    void ShowPlayPopup(int level, int noOfTargets, float time)
    {
        playPopup.gameObject.SetActive(true);
        playPopup.ResetLevelDetails(level, noOfTargets, time);
    }
}
