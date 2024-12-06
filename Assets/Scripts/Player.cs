using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{
    [SerializeField] HealthBar PlayerHealthBar;

    private void Start()
    {
        Init(100);
        PlayerHealthBar.InitHpBar(Health);
    }

}
