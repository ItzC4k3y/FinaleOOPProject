using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Characters : MonoBehaviour
{
    [SerializeField] private float health;

    [SerializeField] private GameObject gameOverUI;
    public Rigidbody2D rb;

    public float Health 
    { get { return health; } 
        set 
        {
            if (value < 0) health = 0;
            else health = value;
        } 
    }

    public void Init(float newHealth)
    {
        Health = newHealth;
    }
    public virtual void TakeDamage(float takeDamage)
    {
        Health -= takeDamage;
        if (IsDead())
        {
            Destroy(gameObject);
            gameOverUI.SetActive(true);
        }
    }

    public bool IsDead()
    {
        return Health <= 0;
    }
}
