using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Detect_Camera : MonoBehaviour
{
    //On enter: camera mesh is false
    //on exit : camera mesh is true

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Camera_Ray")
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Camera_Ray")
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
