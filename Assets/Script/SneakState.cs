using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakState : StateMachineBehaviour
{
    float _delay =2f; //2s //to allow 2nd press of sneak cuz is too fast // en vrai sa sert a rien de mettre 2f LOL

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _delay = Time.timeSinceLevelLoad;
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if ((Input.GetKeyDown(KeyCode.C) && _delay < Time.timeSinceLevelLoad) || (Input.GetButtonDown("JoystickButton0") && _delay < Time.timeSinceLevelLoad)) //have to press again to disable sneak and go idle
        {
            animator.SetBool("isSneak", false);
        }
    }
}
