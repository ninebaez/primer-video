using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    
  public float mousensitivity = 80f;

  public Transform playerbody;

  float xRotation = 0;



    void Start()
    {
        
    }

   
    void Update()
    {
       float mouseX = Input.GetAxis("Mouse X") * mousensitivity * Time.deltaTime;
      
       float mouseY = Input.GetAxis("Mouse Y") * mousensitivity * Time.deltaTime;


       xRotation -= mouseY;

       xRotation=Mathf.Clamp(xRotation, -90f,90);

       transform.localRotation = Quaternion.Euler(xRotation,0f,0f);

       playerbody.Rotate(Vector3.up*mouseX);

    }
}
