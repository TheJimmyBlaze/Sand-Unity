using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    //Properties
    public Animator animator;
    public GameObject swoosh;
    public Transform swooshSpawner;

    public Rigidbody2D rigidBody;
    public float swooshMotionCarryOver = 40f;

    public Camera cam;

    //Members
    private Vector2 mousePosition;

    void Update()
    {
        //Rotate weapons
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDirection = mousePosition - (Vector2)transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //Attack
        bool attacking = Input.GetMouseButtonDown(0);
        if (attacking)
        {
            animator.SetTrigger("Attack");
        }
    }

    void SpawnSwoosh()
    {
        Quaternion rotation = transform.rotation;
        rotation *= Quaternion.Euler(0, 0, -90);

        GameObject spawned = Instantiate(swoosh, swooshSpawner.position, rotation);
        Rigidbody2D spawnedBody = spawned.GetComponent<Rigidbody2D>();
        spawnedBody.AddForce(rigidBody.velocity * swooshMotionCarryOver);
    }
}
