using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOptions : MonoBehaviour
{
    List<int> widths = new List<int>() {568, 960, 1280, 1920}; //widths for resolution
    List<int> heights = new List<int>() {320, 540, 800, 1080}; //heights for resolution

    public void SetScreenSize(int index)
    {
        // Check if screen is fullscreen and set it
        bool fullscreen = Screen.fullScreen;
        // Get width
        int width = widths[index];
        // Get height
        int height = heights[index];

        // Set the resolution
        Screen.SetResolution(width, height, fullscreen);
    }

    public void SetFullScreen(bool _fullscreen)
    {
        // Check if screen is fullscreen and set it
        Screen.fullScreen = _fullscreen;
    }
}