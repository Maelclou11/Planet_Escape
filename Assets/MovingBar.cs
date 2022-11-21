using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBar : MonoBehaviour
{
    public float movingSpeed = 0.1f;

    private GameObject lifeBall;

    private void Start()
    {
        lifeBall = GameObject.FindGameObjectWithTag("LifeBall");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 newPosition = new Vector2(transform.position.x + movingSpeed, transform.position.y);
        // Destroy every block after falling down 5 units under the life ball
        if (transform.position.y < lifeBall.transform.position.y + -5)
        {
            Destroy(gameObject);
        }

        // Enable the gravity when the life ball reach them from a distance of 8 units
        if (transform.position.y <= lifeBall.transform.position.y + 10)
        {
            if (transform.position.x >= -15)
            {
                gameObject.GetComponent<Rigidbody2D>().MovePosition(newPosition);
            }
        }
    }
}
