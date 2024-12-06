using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Characters : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;
    public Image HpBar;
    public Rigidbody2D rb;

    public float Health { get { return health; } set {  health = value; } }
    public float MaxHealth { get {  return maxHealth; } set {  maxHealth = value; } }

    public void TakeDamage(float takeDamage)
    {
        Health -= takeDamage;
    }

    public bool IsDead()
    {
        Destroy(gameObject);
        return Health <= 0;
    }

    void Start()
    {
        MaxHealth = Health;
    }

    void Update()
    {
        HpBar.fillAmount = Mathf.Clamp(Health / MaxHealth, 0, 1);

        if (Health <= 0)
        {
            IsDead();
        }
    }


}
