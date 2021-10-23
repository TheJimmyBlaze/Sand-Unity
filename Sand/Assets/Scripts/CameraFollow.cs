using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset = new Vector3(0, 0, -10);

    private void FixedUpdate()
    {
        //Move Camera
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
