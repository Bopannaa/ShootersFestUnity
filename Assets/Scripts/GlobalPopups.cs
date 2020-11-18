using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPopups : MonoBehaviour
{
    void OnEnable()
    {
        LevelChooser.ActionNoCredit += ShowNoCreditsPopup;
    }

    void OnDisable()
    {
        LevelChooser.ActionNoCredit -= ShowNoCreditsPopup;
    }

    [SerializeField]
    private GameObject noCreditsPopup;

    void ShowNoCreditsPopup()
    {
        noCreditsPopup.SetActive(true);
    }
}
