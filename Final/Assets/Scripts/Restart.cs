using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        // Restart/Go back to first level when button is pressed
        SceneManager.LoadScene("Level01");   
    }
}