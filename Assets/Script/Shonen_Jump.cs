using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shonen_Jump : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponentInParent<Rigidbody>().velocity = new Vector3(0, 10, 0);
    }
}
