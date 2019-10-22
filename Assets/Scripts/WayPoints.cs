using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPoints : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    //List or Array of points which starts at number 0
    public GameObject waypoints;
    Transform[] points;
    public int destPoint = 0;
 
    void Start()
    {
        points = waypoints.GetComponentsInChildren<Transform>();
        agent = GetComponent<NavMeshAgent>();
        //Can turn off autobraking to not stop between waypoints
        agent.autoBraking = false;
        GotoNextPoint ();
    }
    
    void GotoNextPoint()
    {
        if (points.Length == 0){
            return;
        }

        agent.SetDestination (points [destPoint].position);
        //if goes higher than the total number of waypoints -> go back to start of array
        destPoint = (destPoint + 1) % points.Length;
    }

    void Update()
    {
        if (agent.remainingDistance < 0.5f){
            GotoNextPoint ();
        }
    }
}
