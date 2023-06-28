using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool dead = false; // Variable for if player is dead or not

    void Update()
    {
        // Check if player falls off platform and kills them
        if(transform.position.y < -4.5f && !dead)
        {
            Die();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Player dies if it touches an enemy
        if(collision.gameObject.CompareTag("Enemy body"))
        {
            // Makes player disappear and stop moving
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;

            // Kill player
            Die();
        }
    }

    void Die()
    {
        // Wait some time and reload level
        Invoke(nameof(Reload), 1.3f);
        // Set death to true
        dead = true;
    }

    void Reload()
    {
        // Restart the scene at the beginning
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}