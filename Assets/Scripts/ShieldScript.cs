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
    void Update()
    {
        
    }
}
