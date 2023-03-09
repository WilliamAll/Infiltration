using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patroller_Controller : MonoBehaviour
{
    public Transform _targetPosition;
    public Transform WP1; //should make public read only get
    public Transform WP2;

    private NavMeshAgent _agent;
    private Animator _animator;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponentInChildren<Animator>();
    }

    public void PatrollerMoveCurrentTarget() //DEBUG
    {
        _agent.destination = _targetPosition.position;
    }

    public void GoToPositionTarget(Transform _target)
    {
        _agent.destination = _target.position;
    }

    private void OnDrawGizmos()
    {
        RaycastHit _hit;
        Vector3 _dirRayOffset = transform.forward;
        Vector3 _offsetY = new Vector3(0, 1.5f, 0);
        Debug.DrawRay(transform.position + _offsetY, _dirRayOffset * 10f, Color.yellow);


        if (Physics.Raycast(transform.position +_offsetY, _dirRayOffset * 10f, out _hit))
        {
            if(_hit.transform.tag == "Player")
            {
                //Debug.Log("Player hit At this position " + _hit.point);
                _agent.destination = _hit.point;
                transform.LookAt(_hit.point);
                _animator.SetBool("PlayerThere", true);
            }
        }
        //_dirRayOffset = new Vector3(1, 0, 1);
        _dirRayOffset = transform.right;
        Debug.DrawRay(transform.position + _offsetY, _dirRayOffset * 10f, Color.yellow);

        if (Physics.Raycast(transform.position + _offsetY, _dirRayOffset * 10f, out _hit))
        {
            if (_hit.transform.tag == "Player")
            {
                //Debug.Log("Player hit At this position " + _hit.point);
                _agent.destination = _hit.point;
                transform.LookAt(_hit.point);
                _animator.SetBool("PlayerThere", true);
            }
        }
        //_dirRayOffset = new Vector3(-1, 0, 1);
        _dirRayOffset = transform.right * -1;
        Debug.DrawRay(transform.position + _offsetY, _dirRayOffset * 10f, Color.yellow);
        if (Physics.Raycast(transform.position + _offsetY, _dirRayOffset * 10f, out _hit))
        {
            if (_hit.transform.tag == "Player")
            {
                //Debug.Log("Player hit At this position " + _hit.point);
                _agent.destination = _hit.point;
                transform.LookAt(_hit.point);
                _animator.SetBool("PlayerThere", true);
            }
        }

        //target it hit.point
        //what about foreach?
    }
}