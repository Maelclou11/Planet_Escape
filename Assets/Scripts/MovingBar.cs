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

        if (transform.position.y < lifeBall.transform.position.y + -5)
        {
            Destroy(gameObject);
        }


        if (transform.position.y <= lifeBall.transform.position.y + 10)
        {
            if (transform.position.x >= -15)
            {
                gameObject.GetComponent<Rigidbody2D>().MovePosition(newPosition);
            }
        }
    }
}
