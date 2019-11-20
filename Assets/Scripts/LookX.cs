using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    [SerializeField] float sensitivity = 5.0f;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0); //This script gets the axis of the mouse and sets the sensitivity of the rotation so the Player can turn along the x axis without much issue
    }
}
