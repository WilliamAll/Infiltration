using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player WIN.");
        }
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, new Vector3(0, 0, 1) * 3f, Color.green); //USE TO EXIT
        if (Physics.Raycast(transform.position, new Vector3(0, 0, 1), 3f))
        {
            Debug.Log("is WIN");
        }
    }

}
