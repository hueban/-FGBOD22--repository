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
    public void Start()
    {
        curEnergy = maxEnergy;
    }

    public void TakeExhaust(float Exhaust)
    {
        curEnergy -= Exhaust;
        
       energybar.UpdateEnergy((float)curEnergy/(float)maxEnergy);
    }
}
