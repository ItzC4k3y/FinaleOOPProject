using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{
    [SerializeField] public HealthBar PlayerHealthBar;

    public override void TakeDamage(float takeDamage)
    {
        base.TakeDamage(takeDamage);
        PlayerHealthBar.UpdateHp(Health);
    }
    private void Start()   
    {
        Init(60);
        PlayerHealthBar.InitHpBar(Health);
    }
}


