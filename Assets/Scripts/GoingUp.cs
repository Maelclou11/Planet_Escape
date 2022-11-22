using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingUp : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float goingUpSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 newPosition = rb2d.position + Vector2.up * goingUpSpeed;
        rb2d.MovePosition(newPosition);
    }
}
