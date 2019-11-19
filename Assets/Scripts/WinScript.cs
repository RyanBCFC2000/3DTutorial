using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        Debug.Log(collision.gameObject);
        if(collision.gameObject.tag == "Player"){
             Debug.Log("Win");
        SceneManager.LoadScene(3);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
