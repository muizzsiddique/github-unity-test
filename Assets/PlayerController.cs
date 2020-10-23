using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public float thrustSpeed;
    public float turnSpeed;
    public float maxVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float turn = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(0.0f, turn * Time.deltaTime * turnSpeed, 0.0f));

        transform.position += forward * new Vector3(
            Mathf.Cos(Mathf.Deg2Rad * turn * turnSpeed),
            0.0f,
            Mathf.Sin(Mathf.Deg2Rad * turn * turnSpeed)
        );

    }
}
