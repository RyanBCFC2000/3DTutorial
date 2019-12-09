using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    void OnTriggerEnter(Collider collision){
        Debug.Log(collision.gameObject);
        if(collision.gameObject.tag == "Player"){
             Debug.Log("Win");
             Cursor.lockState=CursorLockMode.None;
        SceneManager.LoadScene(3); //If Player enters the radius of the trigger then they win the game
        }
       
    }
}
