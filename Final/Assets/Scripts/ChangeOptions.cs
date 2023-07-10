using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOptions : MonoBehaviour
{
    List<int> widths = new List<int>() {568, 960, 1280, 1920}; //widths for resolution
    List<int> heights = new List<int>() {320, 540, 800, 1080}; //heights for resolution
    [SerializeField] Slider volumeSlider; // Variable for volume

    public void SetScreenSize(int ind)
    {
        // Check if screen is fullscreen and set it
        bool fullscreen = Screen.fullScreen;
        // Get width
        int width = widths[ind];
        // Get height
        int height = heights[ind];

        // Set the resolution
        Screen.SetResolution(width, height, fullscreen);
    }

    public void SetFullScreen(bool fullS)
    {
        // Check if screen is fullscreen and set it
        Screen.fullScreen = fullS;
    }

    void Awake()
    {
        // Set volume to previous volume if set when game starts
        if(PlayerPrefs.HasKey("Volume"))
        {
            SetVolume(PlayerPrefs.GetFloat("Volume"));
            volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        }
    }

    public void SetVolume(float vol)
    {
        // Set volume to the volume chosen
        AudioListener.volume = vol;
        // Save volume for next game
        PlayerPrefs.SetFloat("Volume", vol);
    }
}