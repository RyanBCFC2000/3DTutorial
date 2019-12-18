using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldPickup : MonoBehaviour
{
  void OnTriggerEnter(Collider collider){

        //print("pick up");
        ShieldScript shield = collider.GetComponent<ShieldScript>();
        if (shield != null&&collider.tag == "Player"){
            GetComponent<MeshRenderer>().enabled = false;
            shield.Damage(-10); //Works out whether the Players shield has dropped below 10, if it has then regain 10 health for the pickup
            Destroy(gameObject); //Once the Player has picked up the Shield have it Destroy itself
        }
  }
}
