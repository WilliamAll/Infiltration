using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json.Linq;
using UnityEngine.InputSystem;
using TMPro;

public class Player_Controller : MonoBehaviour
{
    //PUBLIC
    public float Speed; //only use to detect mouvement


    //EXPOSED AND PRIVATE
    [SerializeField] float _moveSpeed, _gravity;
    [SerializeField] Transform _checkGroundTransform;
    [SerializeField] Animator _animator;


    Vector3 move3D;
    Rigidbody _rb;

    //FOR UNITY EVENT
    private void OnJoggingStart(float speed)
    {

    }

    //LIFE CYCLE
    private void Awake()
    {
        TryGetComponent<Rigidbody>(out _rb);
        //TryGetComponent<Animator>(out _animator);
    }

    private void Start()
    {

    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {
        //_rb.velocity = new Vector3(move3D.normalized.x * _moveSpeed, _rb.velocity.y * _gravity, move3D.normalized.z * _moveSpeed); //launch velocity
        //move3D = Camera.main.transform.forward * move3D.z;

        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 moveDirection = cameraForward * move3D.z + Camera.main.transform.right * move3D.x;
        _rb.velocity = new Vector3(moveDirection.x *_moveSpeed, _rb.velocity.y * _gravity, moveDirection.z * _moveSpeed);
    }

    //PLAYER INPUT SYSTEM
    private void OnMove(InputValue value)
    {
        //move3D = value.Get<Vector2>();
        //move3D = new Vector3(value.Get<Vector2>().x, _rb.velocity.y, value.Get<Vector2>().y); //This line can work itself

        move3D = new Vector3(value.Get<Vector2>().x, _rb.velocity.y, value.Get<Vector2>().y); //we could use only x and z
        Speed = Mathf.Abs(value.Get<Vector2>().x) + Mathf.Abs(value.Get<Vector2>().y);
        _animator.SetFloat("Speed", Speed);

        //move3D = Camera.main.transform.forward * move3D.z + Camera.main.transform.right * move3D.x; //this line and bottom is only to move with camera
        //move3D.y = 0; //encrer au sol?

        //move3D = Camera.main.transform.forward * move3D.y;
        //Debug.Log("Value of Move" + value);
    }

    private void CubeCheckGround()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(_checkGroundTransform.position, new Vector3(1, 0.3f, 1));
    }
    private void OnDrawGizmos()
    {
        //CubeCheckGround();

        //bool hit = Physics.BoxCast(_checkGroundTransform.position, new Vector3(1, 0.3f, 1), new Vector3(0,-1,0), Quaternion.identity, 0.05f);
        ////we set the original position, box dimension, direction, orientation, and maximal distance;
        //if (hit)
        //{
        //    Debug.Log("RayCast Hit is = " + hit);
        //}
        //RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer

        Debug.DrawRay(transform.position, new Vector3(0, -1, 0) * 1f, Color.yellow);
        if (Physics.Raycast(transform.position, new Vector3 (0,-1,0), 1f))
        {
            
            //Debug.Log("Did Hit");
            _animator.SetBool("isFalling", false);
        }
        else
        {
            //Debug.Log("NotHit");
            _animator.SetBool("isFalling", true);
        }
    }


    private void BoxCheckerRayCast()
    {
       
    }

    private void ControllerByRelativeCamera()
    {
        //INPUT
        //is move3D or try rigid

        //CAMERA DIRECTION
        //Vector3 foward = transform.InverseTransformVector(Camera.main.transform.forward);
        //Vector3 right = transform.InverseTransformVector(Camera.main.transform.right);

        //move3D = Camera.main.transform.forward * move3D.y;



        //Debug.Log("Value of foward" + foward);
        //foward.y = 0;
        //right = right.normalized;

        //RELATIVE DIRECTION and INPUT

        //Vector3 fowardRelativeVerticalInput = move3D.y * foward;
        //Vector3 rightRelativeVerticalInput = move3D.y * right;

        //Debug.Log("Value of fowardRelative" + fowardRelativeVerticalInput);

        ////RELATIVE CAMERA AND CONTROLLER
        //Vector3 cameraRelativeController = fowardRelativeVerticalInput + rightRelativeVerticalInput;

        //transform.Translate(cameraRelativeController);
        //Debug.Log("Value of CameraRelativeController" + cameraRelativeController);

    }



    //IDLE //NOTHING
    //RUNNING (movespeed)
    //SPRITING (move speed * move faster(only more than 1))
    //SNEAK (move speed * moveSneak)

    //Ground Sneak (can move on floor)
    //Full Ground Sneak (cannot move)


    //NOT AT COLLIDER
    //JUMP > push the player foward
    //FALLING never meet this condition // may conflict if player push foward outside collider and fall // should have nod animator at JUMP PUSH, and FALLING, and JUMP

    //ENTER COLLIDER
    // if enter collider create ray cast for player
    //if press Jump Force to Jump to void
    //if !raycast > falling //disable move
}