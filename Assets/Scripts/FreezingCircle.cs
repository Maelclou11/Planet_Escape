using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezingCircle : MonoBehaviour
{
    private GameObject lifeBall;
    private Cash cash;

    private void Start()
    {
        cash = FindObjectOfType<Cash>();
        lifeBall = GameObject.FindGameObjectWithTag("LifeBall");
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        gameObject.GetComponent<Rigidbody2D>().mass *= 2; 
    }

    void FixedUpdate()
    {
        // Destroy every block after falling down 5 units under the life ball
        if (transform.position.y < lifeBall.transform.position.y + -5)
        {
            Destroy(gameObject);
            cash.Ajouter(1);
        }

        if (transform.position.y < lifeBall.transform.position.y + 5)
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.y <= lifeBall.transform.position.y + 12 || collision.collider.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;


        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (transform.position.y <= lifeBall.transform.position.y + 12 || collision.collider.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
