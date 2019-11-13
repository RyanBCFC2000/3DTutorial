using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNavMovement : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
 
    void Start()
    {
       target = GameObject.FindGameObjectWithTag("Player").transform;
       agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); //Finds target for Enemy to chase and gets the NavMeshAgent from inside the object. 
    }

   
    void Update()
    {
        agent.SetDestination (target.position);
        if(agent.remainingDistance<(agent.stoppingDistance+0.5f)){
            transform.LookAt(target.transform); //Sets the Enemies destination as the targets position, if statement saying that if remaining distance is more than the stopping distance then Enemy will look at the target.
        }
    }
}
