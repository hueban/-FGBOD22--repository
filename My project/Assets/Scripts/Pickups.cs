using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
  private float ammo = 0;
 
  
  private void OnTriggerEnter(Collider other)
  {
    if (other.transform.tag == "Player")
    {
      
      other.GetComponent<Shovel>().totalThrowns+= 3;
      
      Destroy(gameObject);
    }
  }
  
}
