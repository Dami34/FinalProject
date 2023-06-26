using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Player dies if it touches an enemy
        if(collision.gameObject.CompareTag("Enemy body"))
        {
            Die();
        }
    }

    void Die()
    {
        // Makes player disappear and stop moving
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;

        // Wait some time and reload level
        Invoke(nameof(Reload), 1.3f);
    }

    void Reload()
    {
        // Restart the scene at the beginning
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}