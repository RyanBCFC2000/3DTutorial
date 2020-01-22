using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy 
{
    string name;
    float health;
    int damageDealt;

    public Enemy(){
        this.name = "";
        this.health = 100;
    }

    public Enemy(string Snake){
        this.name = Snake;
        this.health = 100;
    }

    public Enemy(string Spider){
        this.name = Spider;
        this.health = 100;
    }
 
}
