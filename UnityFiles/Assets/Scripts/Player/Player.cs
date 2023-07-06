using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
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
        this.health = health;
        this.maxHealth = maxHealth;
        this.mana = mana;
        this.maxMana = maxMana;
        this.strenght = strenght;
        this.intelligence = intelligence;
        this.attackSpeed = attackSpeed;
    }
}
