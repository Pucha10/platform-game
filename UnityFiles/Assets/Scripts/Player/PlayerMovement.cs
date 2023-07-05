using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementSpeed = 5f;
    public float jumpForce = 5f;
    public InputAction playerControls;
    Vector2 moveDirection = Vector2.zero;
    bool isJumping = false;
    Animator playerStickAnimation;

    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable(); 
    }
    private void Start()
    {
        playerStickAnimation = GetComponent<Animator>();
    }
    void Update()
    {
        
        moveDirection = playerControls.ReadValue<Vector2>();
        if (Input.GetKeyDown(KeyCode.W)&&!isJumping)
            Jump();
        StickAttack();
    }
    private void StickAttack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            playerStickAnimation.SetBool("StickAttack", true);
        }
       else if (playerStickAnimation.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
        {
            playerStickAnimation.SetBool("StickAttack", false);
        }
    }
    private void FixedUpdate()
    {
        if (moveDirection.x > 0f)
        {
            transform.localScale = new Vector3(108f, 108f, 108f);
        }
        else if (moveDirection.x < 0f)
        {
            transform.localScale = new Vector3(-108f, 108f, 108f);
        }
        rb.velocity = new Vector2(moveDirection.x * movementSpeed, rb.velocity.y);
    }
    void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        isJumping= true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }

}

