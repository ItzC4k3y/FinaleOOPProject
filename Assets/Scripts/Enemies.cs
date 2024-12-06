using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemies : Characters
{
    [SerializeField] private float damageOnHit;
    public Characters PlayerHealthBar;

    public float DamageOnHit { get; set; }

    public abstract void Behavior();

    private void Start()
    {
        Behavior();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealthBar.Health -= DamageOnHit;
        }
    }
}
