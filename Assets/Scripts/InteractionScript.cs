using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;
            if (Physics.Raycast(mouseRay, out hitInfo)){
                DoorOpenScript door = hitInfo.transform.GetComponent<DoorOpenScript>();
                if (door){
                    door.enabled = true; //When the F Key is pressed this script checks to see whether the Camera is looking at the door and if it is then the interaction takes place and the door opens
                }
            }
        }
    }
}
