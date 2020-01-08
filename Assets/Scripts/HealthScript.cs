using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] int maximumHealth = 100;
     int currentHealth = 0;
     public GameObject losePanel; //Variables that state the currentHealth, maximumHealth and the losePanel
    
    void Start()
    {
        currentHealth = maximumHealth;
    }

    public bool IsDead { get { return currentHealth <= 0; } }

    public int getHealth()
    {
        return currentHealth;
    }

    public int getMaxHealth()
    {
        return maximumHealth;
    }

    public void Damage(int damageValue)
    {
        currentHealth -= damageValue;
        DeathCheck();
        }
        public void Damage(int damageValue, UnityEngine.AI.NavMeshAgent enemyAI){
            
        }
        void DeathCheck(){
            if (currentHealth <= 0)
        {
            currentHealth = 0;
            if(gameObject.tag != "Player"){
                UIScript.updateScore(10);
                Destroy(gameObject);
            }
          else{
                    Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
              losePanel.SetActive(true);
              Time.timeScale = 0; //If the current health is less than 0, health equals 0. If the gameObject is tagged with Player then update the score by 10 and destroy the gameObject
          }
        }
          else if(currentHealth >= 100){
              currentHealth = 100; //Makes sure that the Players health can't go any higher than 100 even when using a health potion
          } 
        }
    }


