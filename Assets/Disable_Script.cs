using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Disable_Script : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Troller"))
        {
            SceneManager.LoadScene("Level_01");
        }
    }
}
