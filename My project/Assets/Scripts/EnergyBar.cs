using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnergyBar : MonoBehaviour
{
   public Image energyBar;

   public void UpdateEnergy(float fraction)
   {
      energyBar.fillAmount = fraction;
   }
}
