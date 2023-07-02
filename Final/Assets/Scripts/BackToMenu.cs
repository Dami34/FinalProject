using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void BackToMain()
    {
        // Go back to main menu after button is pressed
        SceneManager.LoadScene("Start Screen");
    }
}