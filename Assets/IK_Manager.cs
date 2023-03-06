using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK_Manager : MonoBehaviour
{
    //PUBLIC
    public bool _activeIK;
    public Transform _targetIK;
    
    
    Animator _animator;


    private void Awake()
    {
        TryGetComponent<Animator>(out _animator);
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if(_animator)
        {
            if(_activeIK)
            {
                if(_targetIK != null)
                {
                    _animator.SetLookAtWeight(1);
                    _animator.SetLookAtPosition(_targetIK.position);
                }
            }
            else
            {
                _animator.SetLookAtWeight(0);
            }
        }
    }
}
