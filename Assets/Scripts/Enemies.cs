using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemies : Characters
{
    [SerializeField] private float damageOnHit;

    public abstract void Behavior();

    private void Start()
    {
        Behavior();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if( player != null ) 
        {
            player.TakeDamage(damageOnHit);
        }
    }



}
