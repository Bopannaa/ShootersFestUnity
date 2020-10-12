using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

[RequireComponent(typeof(Animator))]
public abstract class Gun : MonoBehaviour
{
    Transform currentTransform;

    [SerializeField]
    protected Animator animator;

    [SerializeField]
    protected bool isAnimPlaying = false;

    void Awake()
    {
        animator = transform.GetComponent<Animator>();
        Scene_Manager.Instance.inputControl.Player.Press.performed += cxt => OnPressed();
        Scene_Manager.Instance.inputControl.Player.Release.performed += cxt => OnReleased();
    }

    void OnEnable()
    {
        currentTransform = this.transform;
        currentTransform.DOMove(currentTransform.localPosition + Vector3.down * 1f, 0.3f).From();
        AnimatorBehavoiur.ActionFinishAnimation += OnAnimationFinished;
    }

    void OnDisable()
    {
        AnimatorBehavoiur.ActionFinishAnimation -= OnAnimationFinished;
        DOTween.Kill(currentTransform);
    }

    public void MakeActive(bool active)
    {
        transform.gameObject.SetActive(active);
    }

    public abstract void Shoot();

    protected abstract void OnPressed();

    protected abstract void OnReleased();

    protected abstract void OnAnimationFinished();

}
