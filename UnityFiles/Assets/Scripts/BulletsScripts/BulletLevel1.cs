using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLevel1 : MonoBehaviour
{
    float lifetime = 10f;
    Player player;
    public Rigidbody2D rb;
    public float speed = 10f;
    void Start()
    {
        player = GameManager.player;
        if (Input.mousePosition.x > Screen.width * 0.5f)
            rb.AddForce(new Vector2(3f, speed), ForceMode2D.Impulse);
        else
            rb.AddForce(new Vector2(-3f, speed), ForceMode2D.Impulse);
        Invoke("DestroyObject", lifetime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Bullet"))
            if (collision.gameObject.CompareTag("Enemy"))
            {
                DestroyObject();
                //add damage
                
            }
            else DestroyObject();
    }
    private void DestroyObject()
    {
        if (gameObject != null) Destroy(gameObject);
    }

}
