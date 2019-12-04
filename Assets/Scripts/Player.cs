using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Stat shield;

    private void Awake()
    {
        health.Initialize();
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            shield.CurrentVal -= 10;
        }
           if (Input.GetKeyDown(KeyCode.E))
        {
            shield.CurrentVal += 10;
        }
    }
}
