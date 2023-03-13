using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle_Tree : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyDown(KeyCode.C)) //DONT EVER TRY TO PUT "OR DOOR" WITH GAMEPAD is CANCEL ALL BUTTUN BELOW
        {
            animator.SetBool("isSneak", true);
        }
        //if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        //{
        //    animator.SetBool("isSneak", true);
        //}

        if (Input.GetButtonDown("Sneak"))
        {
            animator.SetBool("isSneak", true);
        }


        animator.SetBool("isSprint", false);

        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    animator.SetTrigger("isJump");
        //}

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("isJump");
        }
    }
    //Input.GetButton("joystick button 0")
}