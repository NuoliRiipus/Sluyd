using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
    }

    void Update()
    {
        if (transform.position.z < -2f)
        {
            Destroy(gameObject);
        }
    }
}
