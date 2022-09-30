using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public int damage;
    
    private Rigidbody rb;
    private bool targetHit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (targetHit)
        {
            return;
        }

        if (collision.gameObject.GetComponent<BasicEnemy>() != null)
        {
            BasicEnemy enemy = collision.gameObject.gameObject.GetComponent<BasicEnemy>();

            enemy.TakeDamage(damage);
            
            Destroy(gameObject);
        }
        
        
            
            targetHit = true;
           rb.isKinematic = true;
            transform.SetParent(collision.transform);
        
            Debug.Log("colision detected");
    }
}
