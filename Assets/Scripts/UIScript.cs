using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public HealthScript healthScript;
    public Text healthTxt;
    public Slider healthBar;

    public Text scoreNum;
    public Text timeNum;
    static int score;

    void Start()
    {
        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health:  " + healthScript.getHealth(); //This part of the script gets the maximum health and puts it after the text "Health" in the UI
    }

    public static void updateScore(int amount){
        score += amount;
    }

   
    void Update()
    {
      healthBar.value = healthScript.getHealth();
      healthTxt.text = "Health:  " + healthScript.getHealth();
      timeNum.text = "" + (int)Time.time;
      scoreNum.text = score + ""; //This part of the script updates the Health bar and shows the text. Also does this for the score and the time
    }
}
