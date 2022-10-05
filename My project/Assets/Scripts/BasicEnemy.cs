using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicEnemy: MonoBehaviour
{
  public int maxHealth;
  public Healthbar healthbar;
  public int curHealth;
  //[SerializeField] GameObject endscreen;
    
  
  void Start()
  {
    curHealth = maxHealth;
  }
  
  
   
  public void TakeDamage(int damage)
  {
    
    curHealth -= damage; 
      if(curHealth <= 0) { 
            //endscreen.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }
      if (enabled)
      {
        healthbar.UpdateHealt((float)curHealth/(float)maxHealth);
        
      }
  }

}


