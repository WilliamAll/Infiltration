using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json.Linq;
using UnityEngine.InputSystem;

public class Player_Controller : MonoBehaviour
{
    //PUBLIC

    //EXPOSED AND PRIVATE
    [SerializeField] float _moveSpeed;

    Vector3 move3D;
    Rigidbody _rb;

    private void Awake()
    {
        TryGetComponent<Rigidbody>(out _rb);
    }

    //LIFE CYCLE
    private void FixedUpdate()
    {
        _rb.velocity = move3D * _moveSpeed;
    }

    //PLAYER INPUT SYSTEM
    private void OnMove(InputValue value)
    {
        //move3D = value.Get<Vector2>();
        move3D = new Vector3(value.Get<Vector2>().x, 0, value.Get<Vector2>().y); //may change 0 to transform.position y. xyz.
        //Debug.Log("Value of Move" + value);
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