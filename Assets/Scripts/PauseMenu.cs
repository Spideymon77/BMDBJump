using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //This script both pauses the game and displays the pause menu

    private bool isPaused;
    public GameObject pausePanel;

    // Update is called once per frame
    void Update()
    {
        //Activates the public voids down below
        if(Input.GetButtonDown("Pause"))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    //Actually pauses the game
    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        isPaused = true;
    }

    //Actually resumes the game
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        isPaused = false;
    }
}
