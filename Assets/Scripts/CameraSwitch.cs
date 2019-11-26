using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    void Start()
    {
       camera1.SetActive(true); 
       camera2.SetActive(false);
    }

    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, (transform.position + (new Vector3(10, 0, 0))), Color.red);
        if (Physics.Raycast(transform.position, transform.right, 10)) {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        else {
            camera2.SetActive(false);
            camera1.SetActive(true); //This bit of code shows that when the Raycasts transform position to the right is 10 camera 2 is set active whilst camera 1 isn't, but if it is anything other than 10 camera 1 is set active whilst camera 2 isn't
        }
    }
}
