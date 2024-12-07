using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{
    public HealthBar PlayerHealthBar;
    [SerializeField] private GameObject gameOverUI;

    public override void TakeDamage(float takeDamage)
    {
        base.TakeDamage(takeDamage);
        if (IsDead())
        {
            Destroy(gameObject);
            gameOverUI.SetActive(true);
        }
        PlayerHealthBar.UpdateHp(Health);
    }
    private void Start()   
    {
        Init(60);
        PlayerHealthBar.InitHpBar(Health);
    }
}


