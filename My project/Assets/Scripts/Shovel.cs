using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shovel : MonoBehaviour
{
    [Header("References")]  
    public Transform cam;
    public Transform attackPoint;
    public GameObject objectToThrow;
    private Energy myEnergy;
    [Header("Settings")]
    public int totalThrowns;
    public float ThrownCooldown;

    [Header("Throwing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce;

    bool readyToThrow;
    
    public int maxEnergy;
    public EnergyBar energybar;

        private void Start()
        {
            myEnergy = GetComponent<Energy>();
            readyToThrow = true;
        } 
        
        

    private void Update()
    {
        if (Input.GetKeyDown(throwKey) && readyToThrow && totalThrowns > 0 && myEnergy.curEnergy >= 15)
        {
            Throw();
            myEnergy.TakeExhaust(15f);
        }

            

    }
     private void Throw()
     {
        readyToThrow = false;

        GameObject projectile = Instantiate(objectToThrow, attackPoint.position, cam.rotation );
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        Vector3 forceDirection = cam.transform.forward ;
        

        RaycastHit hit;
        
        if (Physics.Raycast(cam.position * -1, cam.forward *-1, out hit, 500f))
        {
            forceDirection = (hit.point - attackPoint.position).normalized;
        }
        Vector3 forceToAdd = forceDirection * throwForce + transform.up * throwUpwardForce;
        
        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        

        totalThrowns--;

        Invoke(nameof(ResetThorw), ThrownCooldown);

     }
        private void ResetThorw()
        {
             readyToThrow = true;
            
        }
    
}
