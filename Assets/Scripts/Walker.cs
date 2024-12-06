using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : Enemies
{
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoint;

    private void FixedUpdate()
    {
        Behavior();
    }
    public override void Behavior()
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

    private void FlipCharacter()
    {
        velocity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}