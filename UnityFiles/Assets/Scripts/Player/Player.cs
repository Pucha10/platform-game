using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player:MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int mana;
    public int maxMana;
    public int strenght;
    public int intelligence;
    public int attackSpeed;

    public Player(int health, int maxHealth, int mana, int maxMana, int strenght, int intelligence, int attackSpeed)
    {
        this.health = 100;
        this.maxHealth = 100;
        this.mana = 100;
        this.maxMana = 100;
        this.strenght = 1;
        this.intelligence = 1;
        this.attackSpeed = 1;
    }
}
