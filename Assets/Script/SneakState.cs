using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakState : StateMachineBehaviour
{
    float _delay =2f; //2s //to allow 2nd press of sneak cuz is too fast

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _delay = Time.timeSinceLevelLoad;
    }

//OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyDown(KeyCode.C) && _delay < Time.timeSinceLevelLoad) //have to press again to disable sneak and go idle
        {
            animator.SetBool("isSneak", false);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
