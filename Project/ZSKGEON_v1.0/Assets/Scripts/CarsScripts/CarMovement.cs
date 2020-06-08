using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 10.0f;
    public Vector2 moveVector;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void FixedUpdate()
    {
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
    }
}
