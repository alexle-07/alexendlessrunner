using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Playercontrollerscript : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float jumpForce = 10f;
    public Transform groundCheckPoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    public AudioClip jump;
    AudioSource playersfx;

    private Rigidbody2D rb;
    private bool isGrounded;
    // Start is called before the first frame update

    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playersfx = GetComponent<AudioSource>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Constant Forward movement
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        // jumping logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

       

    }

    private void Jump()
    {
        // Add an upward force for jumping
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        playersfx.PlayOneShot(jump);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }

}