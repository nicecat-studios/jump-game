using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rbody;
    private float moveInput;
    private float movementSpeed;
    private float jumpForce;

    public bool isGrounded;
    public Transform feetPos;
    public LayerMask whatIsGround;
    public float checkRadius;
    
    private float charger;
    private bool discharge;
    private bool isCharging;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        isCharging = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            charger += Time.deltaTime;
            isCharging = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            discharge = true;
            isCharging = false;
        }
    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded)
        {
            moveInput = Input.GetAxis("Horizontal");
        }
        rbody.velocity = new Vector2(moveInput * movementSpeed, rbody.velocity.y);

        // Stops movement when space is pressed
        if (isCharging && isGrounded)
        {
            movementSpeed = 0;
        }
        else
        {
            movementSpeed = 8;
        }

        if (discharge && isGrounded)
        {
            // Charges the jump
            jumpForce = 10 * charger;
            if (jumpForce > 10)
            {
                jumpForce = 10;
            }
            rbody.velocity = new Vector2(rbody.velocity.x, jumpForce);

            // Reset charge and set discharge to false
            charger = 0f;
            discharge = false;
        }
    }
}