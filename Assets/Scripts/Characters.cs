using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Characters : MonoBehaviour
{
    [SerializeField] private float health;

    public Rigidbody2D rb;

    public float Health { get { return health; } set {  health = value; } }

    public void Init(float newHealth)
    {
        Health = newHealth;
    }
    public void TakeDamage(float takeDamage)
    {
        Health -= takeDamage;
    }

    public bool IsDead()
    {
        Destroy(gameObject);
        return Health <= 0;
    }
}
