using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
    public HealthScript healthScript;
    public Slider playerHealth;
    public Slider healthBar;
    public Text score;
    public Text playerHealthTxt;
    public Text timeTxt;
    public Text healthTxt;
      public Text scoreNum;
    public Text timeNum;
    
    void Start()
    {
        GameManager manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        healthBar = manager.playerHealth;
        healthTxt = manager.playerHealthTxt;
        scoreNum = manager.score;
        timeNum = manager.timeTxt;

        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health:  " + healthScript.getHealth(); //This part of the script is setting up the Health Bar and everything that makes it up

    }

    public void Save()
    {
      GameObject player = GameObject.FindGameObjectWithTag("Player");
      SaveGame saveData = 
      new SaveGame(player.transform.position.x,player.transform.position.y,player.transform.position.z);
      string JSONString = JsonUtility.ToJson(saveData);

      File.WriteAllText(Application.persistentDataPath + "/playerSave.save", JSONString);

    }
}
