using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Escape : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textEscape;



    private void Start()
    {
        _textEscape.gameObject.SetActive(false);
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("Player WIN.");
    //    }
    //}

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, new Vector3(0, 0, 1) * 3f, Color.green); //USE TO EXIT
        if (Physics.Raycast(transform.position, new Vector3(0, 0, 1), 3f))
        {
            Debug.Log("is WIN");
            _textEscape.gameObject.SetActive(true);
        }
    }

    //private void OnDrawGizmos()
    //{
    //    Debug.DrawRay(transform.position, new Vector3(0, 0, 1) * 3f, Color.green); //USE TO EXIT
    //    if (Physics.Raycast(transform.position, new Vector3(0, 0, 1), 3f))
    //    {
    //        Debug.Log("is WIN");
    //        _textEscape.gameObject.SetActive(true);
    //    }
    //}
}
