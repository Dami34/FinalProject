using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void GoToOptions()
    {
        // Goes to options menu when button is pressed
        SceneManager.LoadScene("Options");
    }
}