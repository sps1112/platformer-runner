using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody2D rb2D;

    Animator animator;

    public bool isGrounded;

    public float jumpForce;

    public float gravityModifier;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetFloat("LookDirection", 1f);
        animator.SetBool("IsRunning", true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector2.down * 0.75f, Color.black, 0.1f);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.75f, LayerMask.GetMask("Ground"));
        if (hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
            rb2D.AddForce(Physics2D.gravity * gravityModifier);
        }
        animator.SetBool("IsGrounded", isGrounded);
    }

    void Jump()
    {
        if (isGrounded)
        {
            animator.SetTrigger("Jump");
            rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
