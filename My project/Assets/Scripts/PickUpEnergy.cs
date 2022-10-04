using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpEnergy : MonoBehaviour
{
    [SerializeField] EnergyBar energy; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            
            Energy target = other.gameObject.GetComponent<Energy>();
            target.curEnergy+= 50;
            target.energybar.UpdateEnergy((float)target.curEnergy/(float)target.maxEnergy);
                               
      
            Destroy(gameObject);
            
            
        }
    }
}
