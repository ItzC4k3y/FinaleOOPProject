using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{
    [SerializeField] private HealthBar playerHealthBar;
    [SerializeField] private GameObject gameOverUI;

    public override void TakeDamage(float takeDamage)
    {
        base.TakeDamage(takeDamage);
        if (IsDead())
        {
            Destroy(gameObject);
            gameOverUI.SetActive(true);
        }
        playerHealthBar.UpdateHp(Health);
    }
    private void Start()   
    {
        Init(60);
        playerHealthBar.InitHpBar(Health);
    }
}


