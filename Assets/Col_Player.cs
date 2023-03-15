using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col_Player : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Troller"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponentInParent<Player_Controller>().enabled = false;
            Debug.Log("Player is Spot");
        }
    }
}
