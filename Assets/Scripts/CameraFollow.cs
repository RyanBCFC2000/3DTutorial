﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
      transform.position = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z); //camera gets targets transform position on the x, y and the z axis 
    }
}
