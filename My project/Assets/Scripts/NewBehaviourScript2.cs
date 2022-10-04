using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
   public float sensX;
   public float sensY;

   public Transform orientation;

  float xRotation;
  float yRotation;

  private void start()
  {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
      
  }
  private bool enabled = false;

  public void enableDisable(bool enable)
  {
      enabled = enable;
  }
  private void Update()
  {
      if (enabled)
      {
          float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
                float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensX;
          
                yRotation += mouseX;
          
                xRotation -= mouseY;
          
                xRotation = Math.Clamp(xRotation, -90f, 90f);
                
                transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
           //     orientation.rotation = Quaternion.Euler(0, yRotation, 0);
      }
      
      
  }
} 
