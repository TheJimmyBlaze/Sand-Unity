using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Properties
    public float movementSpeed = 5f;
    public Rigidbody2D rigidBody;
    public Animator animator;
    public Camera cam;

    public bool facingRight = true;

    //Members
    private Vector2 movement;

    private void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Velocity", movement.magnitude);
        animator.SetFloat("Horizontal", movement.x);

        //Mouse
        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDirection = mousePosition - (Vector2)transform.position;
        facingRight = lookDirection.x >= 0 ? true : false;
        animator.SetBool("FacingRight", facingRight);
    }

    private void FixedUpdate()
    {
        //Movement
        Vector2 newPosition = rigidBody.position + movement * movementSpeed * Time.fixedDeltaTime;
        rigidBody.MovePosition(newPosition);
    }
}
