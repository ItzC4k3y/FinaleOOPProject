using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private int moveSpeed;
    [SerializeField] private int jumpForce;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private Animator animator;
    [SerializeField] private bool isOnGround;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0).normalized;

        animator.SetBool("IsMoving", movement.x != 0);
        animator.SetBool("IsJumping", !isOnGround);
        transform.position += movement * moveSpeed * Time.deltaTime;
       
        if ( movement.x > 0) 
            transform.localScale = new Vector2 (Mathf.Abs(transform.localScale.x),(transform.localScale.y));
            
        else if (movement.x < 0)    
            transform.localScale = new Vector2 (Mathf.Abs(transform.localScale.x) * -1, (transform.localScale.y));
      

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rigidBody.AddForce(new Vector2 (0, jumpForce));
        }

        isOnGround =  Physics2D.OverlapCircle(groundCheck.position, 1, groundLayer);
      
    }

}
