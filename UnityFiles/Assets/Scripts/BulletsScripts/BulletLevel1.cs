using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLevel1 : MonoBehaviour
{
    GameManager gameManager;
    public Rigidbody2D rb;
    public float speed = 10f;
    void Start()
    {
        if (Input.mousePosition.x > Screen.width * 0.5f)
            rb.AddForce(new Vector2(3f, speed), ForceMode2D.Impulse);
        else
            rb.AddForce(new Vector2(-3f, speed), ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.gameObject.CompareTag("Bullet")&& !collision.gameObject.CompareTag("Player"))
            Destroy(gameObject); 

        
    }

}
