using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandsAttacks : MonoBehaviour
{
    [SerializeField] GameObject BulletLvl1;
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
    private void WandLevel2Attack() { }
    private void WandLevel3Attack() { }
    private void WandLevel4Attack() { }
    private void WandLevel5Attack() { }
    private void WandLevel6Attack() { }
    private void WandLevel7Attack() { }
}
