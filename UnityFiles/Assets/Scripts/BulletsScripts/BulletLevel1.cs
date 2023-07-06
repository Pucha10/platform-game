using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLevel1 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    void Start()
    {
        rb.AddForce(new Vector2(3f, speed), ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

}
