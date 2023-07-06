using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandsAttacks : MonoBehaviour
{
    public Player player;
    [SerializeField] GameObject BulletLvl1;
    void Update()
    {
        if (transform.GetChild(0).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel1Attack(player.intelligence);
        if (transform.GetChild(1).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel2Attack(player.intelligence);
        if (transform.GetChild(2).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel3Attack(player.intelligence);
        if (transform.GetChild(3).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel4Attack(player.intelligence);
        if (transform.GetChild(4).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel5Attack(player.intelligence);
        if (transform.GetChild(5).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel6Attack(player.intelligence);
        if (transform.GetChild(6).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel7Attack(player.intelligence);

    }
    private void WandLevel1Attack(int intelligence)
    {
        Instantiate(BulletLvl1, transform.GetChild(0).GetChild(0).position, transform.GetChild(0).GetChild(0).rotation);
    }
    private void WandLevel2Attack(int intelligence) { }
    private void WandLevel3Attack(int intelligence) { }
    private void WandLevel4Attack(int intelligence) { }
    private void WandLevel5Attack(int intelligence) { }
    private void WandLevel6Attack(int intelligence) { }
    private void WandLevel7Attack(int intelligence) { }
}
