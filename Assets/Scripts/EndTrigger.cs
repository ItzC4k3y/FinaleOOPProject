using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : LevelCompleted
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelEnd();
        Debug.Log("Level Completed!");
    }
}
   

