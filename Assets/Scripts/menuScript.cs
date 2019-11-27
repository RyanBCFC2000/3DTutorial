using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void returntoMain()
    {
        SceneManager.LoadScene(0); // Looks at Scenemanager and loads scene 
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

    public void loadWinRoom()
    {
        SceneManager.LoadScene(3);
    }

    public void exitGame()
    {
        Application.Quit(); // When Button is clicked quit application
    }
}
