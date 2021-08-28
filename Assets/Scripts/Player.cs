using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Player : MonoBehaviour
{

    [SerializeField]
    float rotSpeed;

    [SerializeField]
    Transform playerParentX;

    [SerializeField]
    Transform playerParentY;

    [SerializeField]
    Ease ease;

    bool isPressed = false;

    Vector3 playerXrot, playerYrot;

    float rotationX;
    float rotationY;

    bool isPaused = true;

    void Awake()
    {
        rotationX = 0;
        rotationY = 0;
        playerXrot = Vector3.right * rotationX;
        playerYrot = Vector3.up * rotationY;
    }

    void OnEnable()
    {
        Game_Manager.Instance.ActionPauseGame += PausePlayer;
        Game_Manager.Instance.ActionResumeGame += ResumePlayer;
        Game_Manager.Instance.ActionResetGame += ResetPlayer;
    }

    void OnDisable()
    {
        Game_Manager.Instance.ActionPauseGame -= PausePlayer;
        Game_Manager.Instance.ActionResumeGame -= ResumePlayer;
        Game_Manager.Instance.ActionResetGame -= ResetPlayer;
    }

    void Start()
    {
        Scene_Manager.Instance.inputControl.Player.Press.performed += cxt => OnPressed();
        Scene_Manager.Instance.inputControl.Player.Release.performed += cxt => OnReleased();
        Scene_Manager.Instance.inputControl.Player.PosDelta.performed += cnt => SetAxisDelta(cnt.ReadValue<Vector2>());
    }

    void SetAxisDelta(Vector2 delta)
    {
        if (isPressed && !isPaused)
        {
            rotationX += delta.x * rotSpeed * Time.deltaTime;
            rotationY += delta.y * rotSpeed * Time.deltaTime;
        }
    }

    void Update()
    {
        rotationY = Mathf.Clamp(rotationY, -10, 30);
        rotationX = Mathf.Clamp(rotationX, -45, 45);
        DOTween.To(() => playerXrot, x => playerXrot = x, Vector3.up * rotationX, 1f).SetEase(ease);
        DOTween.To(() => playerYrot, y => playerYrot = y, Vector3.left * rotationY, 1f).SetEase(ease);

        playerParentX.localEulerAngles = playerXrot;
        playerParentY.localEulerAngles = playerYrot;
    }

    void OnPressed()
    {
        isPressed = true;
    }

    void OnReleased()
    {
        isPressed = false;
    }

    void OnDestroy()
    {
        DOTween.KillAll();
    }

    void PausePlayer()
    {
        isPaused = true;
    }

    void ResumePlayer()
    {
        isPaused = false;
    }

    void ResetPlayer()
    {
        DOTween.KillAll();
        rotationX = 0;
        rotationY = 0;
        playerXrot = Vector3.right * rotationX;
        playerYrot = Vector3.up * rotationY;
        playerParentX.localEulerAngles = Vector3.zero;
        playerParentY.localEulerAngles = Vector3.zero;
    }
}
