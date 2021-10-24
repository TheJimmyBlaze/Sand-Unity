using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwoshController : MonoBehaviour
{
    public float speed = 200f;
    public Rigidbody2D rigidBody;


    void Start()
    {
        rigidBody.AddRelativeForce(Vector3.up * speed);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
