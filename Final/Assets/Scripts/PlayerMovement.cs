using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb; // Rigidbody variable
    [SerializeField] float movementSpeed = 6f; // Player movement speed
    [SerializeField] float jumpF = 5f; // Force of jump
    [SerializeField] Transform groundCheck; // Used to check if player's on ground
    [SerializeField] LayerMask ground; // Helps passes layers

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get movement inputs
        float horizontalIn = Input.GetAxis("Horizontal");
        float verticalIn = Input.GetAxis("Vertical");

        // Let player move around
        rb.velocity = new Vector3(horizontalIn * movementSpeed, rb.velocity.y, verticalIn * movementSpeed);

        // Let player jump
        if(Input.GetButtonDown("Jump") && isGround())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpF, rb.velocity.z);
        }
    }

    bool isGround()
    {
        // Check and return if player is on the ground
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
}