using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb; // Rigidbody variable
    [SerializeField] float movementSpeed = 6f; // Player movement speed
    [SerializeField] float jumpF = 5f; // Force of jump

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get movement inputs
        float horizontalIn = Input.GetAxis("Horizontal");
        float verticalIn = Input.GetAxis("Vertical");

        // Let player move around
        rb.velocity = new Vector3(horizontalIn * movementSpeed, rb.velocity.y, verticalIn * movementSpeed);

        // Let player jump
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpF, rb.velocity.z);
        }
    }
}