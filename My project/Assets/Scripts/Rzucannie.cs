using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rzucannie : MonoBehaviour
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
    private Vector3 randomForce;
    public int maxEnergy;
    public EnergyBar energybar;
    private bool enabled = false;

    public void enableDisable(bool enable)
    {
        enabled = enable;
    }

        private void Start()
        {
            myEnergy = GetComponent<Energy>();
            readyToThrow = true;
        } 
        
        

    private void Update()
    {
        if (enabled)
        {
            if (Input.GetKeyDown(throwKey) && readyToThrow && totalThrowns > 0 && myEnergy.curEnergy >= 10)
            {
                Throw();
                myEnergy.TakeExhaust(10f);
            }
        }
        

            

    }
     public void Throw()
     {
        readyToThrow = false;

        GameObject projectile = Instantiate(objectToThrow, attackPoint.position, cam.rotation );
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        Vector3 forceDirection = cam.transform.forward ;
        

        RaycastHit hit;
        
        if (Physics.Raycast(cam.position, cam.forward, out hit, Mathf.Infinity))
        {
            forceDirection = (hit.point - attackPoint.position).normalized;
            
        }
        randomForce = new Vector3(Random.Range(-4.55f,4.55f),Random.Range(-4.55f,4.55f),Random.Range(-4.55f,4.55f));
        Vector3 forceToAdd = forceDirection * throwForce + transform.up * throwUpwardForce + randomForce;
        
        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        

        totalThrowns--;

        Invoke(nameof(ResetThorw), ThrownCooldown);

     }
        private void ResetThorw()
        {
             readyToThrow = true;
            
        }
    
}
