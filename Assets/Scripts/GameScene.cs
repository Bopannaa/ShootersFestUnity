using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GameScene : MonoBehaviour
{
    public static Action ActionPauseButton;
    public static Action ActionShootButton;
    public static Action ActionSwapButton;
    public static Action ActionShootButtonRelease;

    public static Action<TextMeshProUGUI> ActionSetRemainingTarget;

    [SerializeField]
    private TextMeshProUGUI remainingTargetsText;

    [SerializeField]
    private TextMeshProUGUI timerText;

    [SerializeField]
    private RectTransform LoosePanel;

    Game_Manager game_Manager;

    void Awake()
    {
        game_Manager = Game_Manager.Instance;
    }

    void OnEnable()
    {
        game_Manager.ActionSetTimeValue += SetTimerText;
        game_Manager.ActionSetTargetValue += SetTargetText;
        game_Manager.ActionLooseGame += ActivateLoosePanel;
    }

    void OnDisable()
    {
        game_Manager.ActionSetTimeValue -= SetTimerText;
        game_Manager.ActionSetTargetValue -= SetTargetText;
        game_Manager.ActionLooseGame -= ActivateLoosePanel;
    }

    void Start()
    {
        game_Manager.StartGame();
        Game_Manager.Instance.ResumeGame();
    }

    void SetTargetText(int no)
    {
        remainingTargetsText.text = "Targets: " + no.ToString();
    }

    void SetTimerText(float no)
    {
        timerText.text = no.ToString("F2");
    }

    void ActivateLoosePanel()
    {
        LoosePanel.gameObject.SetActive(true);
    }

    public void OnPauseButtonClick()
    {
        if (ActionPauseButton != null)
        {
            ActionPauseButton();
        }
    }

    public void OnShootButtonClick()
    {
        if (ActionShootButton != null)
        {
            ActionShootButton();
        }
    }

    public void OnShootButtonRelease()
    {
        if (ActionShootButtonRelease != null)
        {
            ActionShootButtonRelease();
        }
    }

    public void OnSwapButtonClick()
    {
        if (ActionSwapButton != null)
        {
            ActionSwapButton();
        }
    }

    void OnDestroy()
    {
        Game_Manager.Instance.PauseGame();
    }
}
