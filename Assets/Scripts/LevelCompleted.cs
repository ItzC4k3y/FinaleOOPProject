using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MainUi
{
    public GameObject LevelFinished;

    public void LevelEnd()
    {
        Time.timeScale = 0f;
        LevelFinished.SetActive(true);
    }


}
