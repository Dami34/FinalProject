using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollect : MonoBehaviour
{
    int coinsNum = 0; // Keeps track of coins collected
    [SerializeField] TextMeshProUGUI coinText; // Variable to display coin score
    [SerializeField] AudioSource collectSound; // Variable for the coin collecting sound effect

    void OnTriggerEnter(Collider other)
    {
        // Check if player collides with coin and destroys it
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinsNum++; // Add to coin score
            coinText.text = "Coins: " + coinsNum; // Display Score
            collectSound.Play(); // Play sound effect
        }
    }
}