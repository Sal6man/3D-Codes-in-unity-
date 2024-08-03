using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetlslnteracting : StateMachineBehaviour
{

     //OnStateMove is called right after Animator.OnAnimatorMove()
    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("isInteracting", false);
    }
       

    

}
