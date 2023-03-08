using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChasePlayer : StateMachineBehaviour
{
    [SerializeField] float _delay = 3f;
    private float _time;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //_time = Time.timeSinceLevelLoad;
        //Debug.Log("Enter to Chase");
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //if (Time.timeSinceLevelLoad >= _time +_delay) //flemme
        //{
        //    animator.SetBool("PlayerThere", false);
        //}
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("PlayerThere", false);
    }
}
