using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : Characters
{
    [SerializeField] private float damageOnHit;
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoint;

    private void Start()
    {
        Init(100);
        Behavior();
    }
    private void FixedUpdate()
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

    public override void TakeDamage(float takeDamage)
    {
        base.TakeDamage(takeDamage);
        if (IsDead())
        {
            Destroy(gameObject);
        }
    }
    public void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);

        if (rb.position.x <= movePoint[0].position.x && velocity.x < 0)
        {
            FlipCharacter();
        }

        else if (rb.position.x >= movePoint[1].position.x && velocity.x > 0)
        {
            FlipCharacter();
        }
    }

    public void FlipCharacter()
    {
        velocity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

}
