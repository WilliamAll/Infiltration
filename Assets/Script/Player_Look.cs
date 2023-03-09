using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class Player_Look : MonoBehaviour
{
    //private InputAction _inputAction;
    [SerializeField] float sensitivity = 0.5f;
    //[SerializeField] float ClampingVertical = 0f;


    Vector2 mouseDelta;

    private void Awake()
    {

    }

    private void Update()
    {
        RayCastDebug();
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y + mouseDelta.x, 0f);
    }

    private void OnEnable()
    {
        //_player_Input.Player.Look.performed += OnLook;
    }
    private void OnDisable()
    {
        //_player_Input.Player.Look.performed -= OnLook;
    }


    void RayCastDebug()
    {
        Vector3 camPos = Camera.main.transform.position;
        Vector3 camDir = Camera.main.transform.forward;
        Ray ray = new Ray(camPos, camDir);
        float rayLength = 100f;
        Debug.DrawLine(ray.origin, ray.origin + ray.direction * rayLength, Color.green);
    }


    public void OnLook(InputValue value) //InputAction.CallbackContext context
    {
        mouseDelta = value.Get<Vector2>() * sensitivity; // * Time.deltaTime; //may should be fixed update



        //Mathf.Clamp(mouseDelta.y,0.45f,0.5f);
        //transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y + mouseDelta.x, 0f);

        //Debug.Log("Value of MouseDelta" + mouseDelta);
        //float currentXRotation = transform.eulerAngles.x; //if look to floor is say 90 if look front is 0 or 360
        //float newXRotation = currentXRotation - mouseDelta.y; //that line set the vertical orientation
        //transform.rotation = Quaternion.Euler(newXRotation, transform.eulerAngles.y + mouseDelta.x, 0f); //that line allow vertical orientation

        //RayCastDebug();
    }
    public void OnStickLookHorizontal(InputValue value)
    {
        float readHorizontal = value.Get<float>();
        mouseDelta.x= readHorizontal * sensitivity * 3f;
    }

    public void OnStickLookVertical(InputValue value)
    {
        float readVertical = value.Get<float>();
        mouseDelta.y = readVertical * sensitivity * 3f;
    }
}
