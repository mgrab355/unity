using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float jumpForce = 15f;
    private float horizontal;
    private bool facingRight= true;
    public Animator animator;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    void Start()
    {
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(horizontal));
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && rb.velocity.y > 0f)
        { 
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);

        }
        if (!isGrounded()){

         animator.SetBool("isjumping", true);
        }
        else
        {
            animator.SetBool("isjumping", false);
            
        }
        facing();
    }
    private void FixedUpdate(){
        rb.velocity = new Vector2(horizontal *moveSpeed, rb.velocity.y);
    }
    private void facing()
    {
        if (facingRight && horizontal <0f || !facingRight && horizontal>0f)
        {
            facingRight = !facingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *=-1f;
            transform.localScale = localScale;

        }   
    }
    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position,0.2f, groundLayer);
    }
}