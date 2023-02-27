using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //PLAYER INPUT SYSTEM

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
        //if !raycast > falling
}