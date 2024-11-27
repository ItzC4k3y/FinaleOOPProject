using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MainMenu
{
    public static bool isGamePaused = false;

    public GameObject pauseMenu;

    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused) 
            {
                Resume();
            }

            else
            {
               Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        isGamePaused = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
}
