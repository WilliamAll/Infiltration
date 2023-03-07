using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarutoTree : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("isSprint", true);
            //Debug.Log("LeftShit Detected");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("isJump");
        }
    }
}
