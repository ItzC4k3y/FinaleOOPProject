using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MainUi
{
    public GameObject GameIsOver;

    private void GameEnd()
    {
        GameIsOver.SetActive(true);
    }
}
