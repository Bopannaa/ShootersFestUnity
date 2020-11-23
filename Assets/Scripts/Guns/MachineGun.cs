using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : Gun
{
    private bool isShooting = false;

    void OnEnable()
    {
        GameScene.ActionShootButtonRelease += OnShootButtonRelease;
    }

    void OnDisable()
    {
        GameScene.ActionShootButtonRelease -= OnShootButtonRelease;
    }

    public override void Shoot()
    {
        if (this.gameObject.activeInHierarchy == true)
        {
            animator.SetBool("IsShooting" , true);
            isShooting = true;
            StartCoroutine(WaitAndShoot(1));
        }
    }

    protected override void OnAnimationFinished()
    {
        
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

    void OnShootButtonRelease()
    {
        animator.SetBool("IsShooting" , false);
        isShooting = false;
    }

    // every 2 seconds perform the shoot()
    private IEnumerator WaitAndShoot(float waitTime)
    {
        while (isShooting)
        {
            ShootRay();
            yield return new WaitForSeconds(waitTime);
        }
    }
}
