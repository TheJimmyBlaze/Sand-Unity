using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Properties
    public float movementSpeed = 5f;
    public Rigidbody2D rigidBody;
    public Animator animator;

    //Members
    private Vector2 movement;

    private void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Animation
        animator.SetFloat("Velocity", movement.magnitude);
        animator.SetFloat("Horizontal", movement.x);
    }

    private void FixedUpdate()
    {
        //Movement
        Vector2 newPosition = rigidBody.position + movement * movementSpeed * Time.fixedDeltaTime;
        rigidBody.MovePosition(newPosition);
    }
}
