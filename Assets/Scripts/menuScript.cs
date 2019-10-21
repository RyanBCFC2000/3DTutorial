using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void returntoMain()
    {
        SceneManager.LoadScene(0);
    }
    public void loadMain()
    {
        Time.timeScale = 1;
        Debug.Log("load main");
        SceneManager.LoadScene(1);
    }

    public void loadControl()
    {
        SceneManager.LoadScene(2);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
