using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy: MonoBehaviour
{
  public int maxHealth;
  public Healthbar healthbar;
  public int curHealth;
  

  
  void Start()
  {
    curHealth = maxHealth;
  }
  
  
   
  public void TakeDamage(int damage)
  {
    
    curHealth -= damage; 
      if(curHealth <=0)
        Destroy(gameObject);
      if (enabled)
      {
        healthbar.UpdateHealt((float)curHealth/(float)maxHealth);
        
      }
  }

}


