using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWeapon : MonoBehaviour
{
    public void Update()
    {
        
        if (Input.GetKeyDown("1"))
        {
            transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown("2"))
        {
            transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(4).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(5).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(6).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown("3"))
        {
            transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(4).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(5).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(6).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown("4"))
        {
            transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(4).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(5).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(6).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown("5"))
        {
            transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(4).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(5).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(6).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown("6"))
        {
            transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(4).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(5).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(6).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown("7"))
        {
            transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(4).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(5).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(6).gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown("8"))
        {
            transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(4).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(5).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).GetChild(1).GetChild(6).gameObject.SetActive(true);
        }
    }
}
