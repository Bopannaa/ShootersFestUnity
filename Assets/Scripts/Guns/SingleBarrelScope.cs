using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBarrelScope : Gun
{
public override void Shoot()
    {
        if (this.gameObject.activeInHierarchy == true)
        {
            if (!isAnimPlaying)
            {
                isAnimPlaying = true;
                animator.SetTrigger("Shoot");
                ShootRay();
            }
        }
    }

    protected override void OnAnimationFinished()
    {
        isAnimPlaying = false;
    }

    protected override void OnPressed()
    {
        if (this.gameObject.activeInHierarchy == true)
        {
            animator.SetBool("IsIdle", false);
        }
    }

    protected override void OnReleased()
    {
        if (this.gameObject.activeInHierarchy == true)
        {
            animator.SetBool("IsIdle", true);
        }
    }
}
