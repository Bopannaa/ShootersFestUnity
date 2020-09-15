using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBarrel : Gun
{
    [SerializeField]
    private AnimationClip singleShootAnimation;

    [SerializeField]
    private AnimationClip bothShootAnimation;

    [SerializeField]
    private AnimationClip bothIdleAnimation;

    [SerializeField]
    private AnimationClip singleIdleAnimation;

    [SerializeField]
    private AnimationClip bothStillAnimation;

    [SerializeField]
    private AnimationClip singleStillAnimation;

    [SerializeField]
    private AnimationClip reloadAnimation;

    public override void Reload()
    {
        Debug.Log("Reload");
        remainingShots = maxShots;
        isReloading = false;
    }

    public override void Shoot()
    {
        if (!isReloading)
        {
            Debug.Log("Shoot");
            animator.Play(singleShootAnimation.name);
            remainingShots--;
            if (remainingShots <= 0)
            {
                isReloading = true;
                Reload();
            }
        }
    }
}
