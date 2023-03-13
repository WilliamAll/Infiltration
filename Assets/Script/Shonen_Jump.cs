using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shonen_Jump : StateMachineBehaviour
{
    float _delay, _endDelay; // not even delay

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _delay = Time.timeSinceLevelLoad;
        //_endDelay = _delay + 0.5f;
        //animator.transform.position = Vector3.Lerp(animator.transform.position, animator.transform.position + new Vector3 (0,5,0), 0.1f);

    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Time.timeSinceLevelLoad > _delay + 0.85f) animator.GetComponentInParent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        // should acces to gravity variable and write it to set at 1 instead 0



        //Vector3 origin = new Vector3(0,0, 0);
        //Vector3 desti = new Vector3(0, 5, 0);
        //if (Time.timeSinceLevelLoad > _delay + 0.85f && _delay <_endDelay)
        //{
        //    animator.transform.position = Vector3.Lerp(animator.transform.position, animator.transform.position + desti, 0.1f);
        //}
    }
}
