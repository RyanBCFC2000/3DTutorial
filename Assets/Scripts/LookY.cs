using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    [SerializeField] float sensitivityY;
    public float minimumY = -30F;
    public float maximumY = 30F;
    float rotationY = 0F;

    void Start()
    {
        
    }

  
    void Update()
    {
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY; //This script gets the axis of the mouse and sets the sensitivity of the rotation so the Player can turn along the y axis without much issue
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0); 
    }
}
