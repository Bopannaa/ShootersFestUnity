using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Animator))]
public abstract class Gun : MonoBehaviour
{
    Transform currentTransform;

    [SerializeField]
    protected int maxShots;

    protected int remainingShots;
    protected bool isReloading = false;

    [SerializeField]
    protected Animator animator;

    void Awake()
    {
        remainingShots = maxShots;
        animator = transform.GetComponent<Animator>();
    }

    void OnEnable()
    {
        currentTransform = this.transform;
        currentTransform.DOMove(currentTransform.localPosition + Vector3.down *  1f, 0.3f).From();
    }

    void OnDisable()
    {
        DOTween.Kill(currentTransform);
    }

    public void MakeActive(bool active)
    {
        transform.gameObject.SetActive(active);
    }

    public abstract void Shoot();
    public abstract void Reload();
}
