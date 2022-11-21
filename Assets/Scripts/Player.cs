using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float moveSpeed = 0.5f;


    Vector3 mousePosition;
    Vector2 position = new Vector2(0f, 0f);
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Mouse Control

        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        // Rotation Command
        if (Input.GetKey("w"))
            rb2d.MoveRotation(rb2d.rotation + rotationSpeed);

        if (Input.GetKey("s"))
            rb2d.MoveRotation(rb2d.rotation - rotationSpeed);

        if (Input.GetMouseButtonDown(2))
            rb2d.MoveRotation(0);

        if (Input.GetMouseButton(1))
            rb2d.MoveRotation(rb2d.rotation - rotationSpeed);
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(position);
    }
}
