using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaHealthBars : MonoBehaviour
{
    Player player;
    [SerializeField] Image health;
    [SerializeField] Image mana;
    void Start()
    {
        player = GameManager.player;
    }
    // Update is called once per frame
    void Update()
    {
        float healthAmount = player.health / player.maxHealth;
        health.fillAmount = healthAmount;
        float manaAmount = player.mana/player.maxMana;
        mana.fillAmount = manaAmount;
    }
}
