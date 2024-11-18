using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float length;
    [SerializeField] float speed;

    enum Direction { horizontal, vertical }
    [SerializeField] Direction selectedDirection;

    Vector3 startPos;
    Rigidbody rb;
    Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = rb.position;

        if (selectedDirection == Direction.vertical)
        {
            direction = Vector3.forward;
        }
        else
        {
            direction = Vector3.right;
        }

    }


    void FixedUpdate()
    {
        rb.position = startPos + Mathf.Sin(Time.time * speed) * length * direction;
    }
}
