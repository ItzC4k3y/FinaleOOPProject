using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HeadCheck : MonoBehaviour
{
    [SerializeField] Enemies enemies;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyHeadCheck>())
        {
            enemies.TakeDamage(50);
        }
    }
}
