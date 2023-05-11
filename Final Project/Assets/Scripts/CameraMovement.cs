using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSens = 30f;
    public float ySens = 30f;
 // Update is called once per frame
    void Update () 
    {
        //PlayerLook();
    }
    public void PlayerLook()
    {
        float mouseX = (Input.mousePosition.x / Screen.width) - .5f;
        float mouseY = (Input.mousePosition.y / Screen.height) - .5f;
        xRotation -= (mouseY = Time.deltaTime) * ySens;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.forward * (mouseX * Time.deltaTime) * xSens);
    }
}
