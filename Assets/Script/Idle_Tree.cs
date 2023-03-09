using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle_Tree : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("isSneak", true);
        }
        animator.SetBool("isSprint", false);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("isJump");
        }
    }
}