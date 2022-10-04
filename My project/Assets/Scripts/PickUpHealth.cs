using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            
            BasicEnemy target = other.gameObject.GetComponent<BasicEnemy>();
            target.curHealth+= 50;
            target.healthbar.UpdateHealt((float)target.curHealth/(float)target.maxHealth);
                               
      
            Destroy(gameObject);
            
            
        }
    }
}
