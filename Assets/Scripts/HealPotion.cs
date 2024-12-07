using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPotion : PickUps
{
    [SerializeField] private float heal;


    public override void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        base.OnTriggerEnter2D(collision);

        if (player.Health >= 60)
        { 
            player.Health = 60; 
        }

        else
        {
            player.Health += heal;
            player.PlayerHealthBar.UpdateHp(player.Health);
        }
    }
  
}
