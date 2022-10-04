using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public int maxEnergy;
    public EnergyBar energybar;
    public float curEnergy;
    [SerializeField] private GameObject turnmmanager;
    private TrunManager turnManagerScript;
    public void Start()
    {
        turnManagerScript= turnmmanager.GetComponent<TrunManager>();
        curEnergy = maxEnergy;
    }

    
    public void TakeExhaust(float Exhaust)
    {
        curEnergy -= Exhaust;
        if (curEnergy <= 0)
        {
            turnManagerScript.nextTurnWait();
            curEnergy = maxEnergy;
        }
        
       energybar.UpdateEnergy((float)curEnergy/(float)maxEnergy);
    }
}
