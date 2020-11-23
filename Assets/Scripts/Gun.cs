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

    [SerializeField]
    protected GameObject pointer;

    void Awake()
    {
        animator = transform.GetComponent<Animator>();
        Scene_Manager.Instance.inputControl.Player.Press.performed += cxt => OnPressed();
        Scene_Manager.Instance.inputControl.Player.Release.performed += cxt => OnReleased();
    }

    void OnEnable()
    {
        currentTransform = this.transform;
        //currentTransform.DOMove(currentTransform.localPosition + Vector3.down * 1f, 0.3f);
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

    protected void ShootRay()
    {
        RaycastHit hit;
        if (Physics.Raycast(pointer.transform.position, pointer.transform.TransformDirection(Vector3.forward), out hit, 1000))
        {
            Debug.Log("Shoot Performed");
            if (hit.collider.transform.tag == "Balloon")
            {
                hit.transform.gameObject.SetActive(false);
            }
        }
    }

}
