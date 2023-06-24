using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Let player jump
        if(Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }

        // Move player up
        if(Input.GetKey("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }

        // Move player right
        if(Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
        }

        // Move player down
        if(Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        }

        // Move player right
        if(Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
        }
    }
}
