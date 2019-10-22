using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RTSStyle : MonoBehaviour
{
    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;
   
    void Start()
    {
       agent = GetComponent<NavMeshAgent>(); 
    }


    void Update()
    {
      if (Input.GetMouseButton (0)){
          //holds the info about raycast
          RaycastHit hit;

          //launch a raycast from the middle of the camera to a point
          if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)){
              agent.destination = hit.point;
          }
      }  
    }
}
