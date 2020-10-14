using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimatorBehavoiur : StateMachineBehaviour
{
    public static Action ActionFinishAnimation;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(ActionFinishAnimation != null)
        {
            ActionFinishAnimation();
        }
    }
}
