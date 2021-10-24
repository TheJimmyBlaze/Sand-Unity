using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwoshController : MonoBehaviour
{
    public float speed = 200f;
    public Rigidbody2D rigidBody;

    private void FixedUpdate()
    {
        rigidBody.velocity = transform.up * speed * Time.fixedDeltaTime;
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
