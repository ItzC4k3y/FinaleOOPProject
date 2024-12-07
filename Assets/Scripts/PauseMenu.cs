using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MainUi
{
    public bool IsGamePaused = false;

    public GameObject PauseMenuUi;

    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused) 
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
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        IsGamePaused = false;
    }

    public void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        IsGamePaused = true;
    }
}
