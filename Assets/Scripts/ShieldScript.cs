using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    int maximumShield = 10;

    int currentShield = 0;
    void Start()
    {
        currentShield = maximumShield;

    }

   public int getShield(){
       return currentShield;
   }

   public int getMaxShield(){
       return maximumShield;
   }

   public void Damage(int damageValue)
    {
        currentShield -= damageValue;

        if (currentShield <= 0)
        {
            currentShield = 0;
        }
          else if(currentShield >= 10){
              currentShield = 10; //Makes sure that the Players health can't go any higher than 100 even when using a health potion
          }
    }
}
