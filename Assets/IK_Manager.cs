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

    }

    private void Start()
    {
        TryGetComponent<Animator>(out _animator);
        if(_animator != null)
        {
            Debug.Log("Get Animator at IK");
        }
        else
        {
            Debug.LogError("No Animator at IK");
        }
    }

    private void OnAnimatorIK()
    {
        Debug.Log("OnAnimatorIK");
        if(_animator)
        {
            if(_activeIK)
            {
                if(_targetIK != null)
                {
                    Debug.Log("isIk");
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
