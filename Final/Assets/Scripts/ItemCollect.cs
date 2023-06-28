using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollect : MonoBehaviour
{
    int coinsNum = 0; // Keeps track of coins collected
    [SerializeField] TextMeshProUGUI coinText;

    void OnTriggerEnter(Collider other)
    {
        // Check if player collides with coin and destroys it; then adds to coin score
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinsNum++;
            coinText.text = "Coins: " + coinsNum;
        }
    }
}