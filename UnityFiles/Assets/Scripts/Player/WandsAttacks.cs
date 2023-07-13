using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WandsAttacks : MonoBehaviour
{
    [SerializeField] GameObject BulletLvl1;
    [SerializeField] GameObject BulletLvl2;
    [SerializeField] GameObject BulletLvl3;

    void Update()
    {
        if (transform.GetChild(0).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel1Attack();
        if (transform.GetChild(1).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel2Attack();
        if (transform.GetChild(2).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel3Attack();
        if (transform.GetChild(3).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel4Attack();
        if (transform.GetChild(4).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel5Attack();
        if (transform.GetChild(5).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel6Attack();
        if (transform.GetChild(6).gameObject.activeSelf && Input.GetButtonDown("Fire1")) WandLevel7Attack();

    }
    private void WandLevel1Attack()
    {
        Instantiate(BulletLvl1, transform.GetChild(0).GetChild(0).position, transform.GetChild(0).GetChild(0).rotation);
    }
    private void WandLevel2Attack() 
    {
        Instantiate(BulletLvl2, transform.GetChild(1).GetChild(0).position, transform.GetChild(1).GetChild(0).rotation);
    }
    private void WandLevel3Attack() 
    {
        Invoke("InstantiateBullet3", 0f);
        Invoke("InstantiateBullet3", 0.25f);
        Invoke("InstantiateBullet3", 0.5f);
    }
    private void WandLevel4Attack() { }
    private void WandLevel5Attack() { }
    private void WandLevel6Attack() { }
    private void WandLevel7Attack() { }
    void InstantiateBullet3()
    {
        Instantiate(BulletLvl3, transform.GetChild(2).GetChild(0).position, transform.GetChild(2).GetChild(0).rotation);
    }
}
