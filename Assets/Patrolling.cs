using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : StateMachineBehaviour
{
    //Serialized transform is useless here ...

    Vector3 _allowVector;


    Patroller_Controller _pc;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _pc = animator.GetComponentInParent<Patroller_Controller>();
        _pc.GoToPositionTarget(_pc.WP2);
        //Debug.Log("Enter to Patrolling");
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _allowVector = new Vector3(1,0,1);
        if (

            (  (animator.transform.position.x >= _pc.WP2.position.x - _allowVector.x) && (animator.transform.position.x <= _pc.WP2.position.x + _allowVector.x)   ) //if current.x >WP2 -1 && current.x < WP2 +1
            &&
            (  (animator.transform.position.z >= _pc.WP2.position.z - _allowVector.z) && (animator.transform.position.z <= _pc.WP2.position.z + _allowVector.z)   ) //if current.z >WP2 -1 && current.x < WP2 +1

            )_pc.GoToPositionTarget(_pc.WP1);


        if (

            (   (animator.transform.position.x >= _pc.WP1.position.x - _allowVector.x) && (animator.transform.position.x <= _pc.WP1.position.x + _allowVector.x)    ) //if current.x >WP1 -1 && current.x < WP1 +1
            &&
            (   (animator.transform.position.z >= _pc.WP1.position.z - _allowVector.z) && (animator.transform.position.z <= _pc.WP1.position.z + _allowVector.z)    ) //if current.z >WP1 -1 && current.x < WP1 +1

            )_pc.GoToPositionTarget(_pc.WP2);


        //if (animator.transform.position == _pc.WP1.position) _pc.GoToPositionTarget(_pc.WP2); // we would use it but no
    }

    private void RadiusAllowWP()
    {
        // si Vector3 compris entre A et B alors valide
        //si position XY compris entre XY1 et XY2 alors valide
        //code est donc si XY>XY1 && XY<XY2 alors valide
        //code v2 est donc XY1 = XY - 1 et XY2 = XY +1
        //remplacer par des float

        //tenir compte des WP
        /*
         *PARAMETRE cest donc = Position actuel WP1 WP2 et tolerance 
         * METHOD
         * Si position actuel est egale a la position WP2 avec plus ou moins de tolerance alors valide
         * code est donc currentPosition == WP2-1 ou WP2+1
         * codeV2 est donc current position == WP2 
         * 
         * 
         */

    }
}