using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){

        //print("pick up");
        HealthScript health = collider.GetComponent<HealthScript>();
        if (health != null&&collider.tag == "Player"){
            GetComponent<MeshRenderer>().enabled = false;
            health.Damage(-50); //Works out whether the Players health has dropped below 100, if it has then regain 50 health for the pickup
            Destroy(gameObject); //Once the Player has picked up the Potion have it Destroy itself
        }
    }

}
