using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Go to first level when start button is pressed
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}