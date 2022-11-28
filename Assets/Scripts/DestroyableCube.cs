using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableCube : MonoBehaviour
{
    private GameObject lifeBall;
    private Cash cash;

    private void Start()
    {
        lifeBall = GameObject.FindGameObjectWithTag("LifeBall");
        cash = FindObjectOfType<Cash>();
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.y <= lifeBall.transform.position.y + 16)
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void FixedUpdate()
    {
        if (transform.position.y < lifeBall.transform.position.y + -5)
        {
            Destroy(gameObject);
            cash.AddCash(1);
        }
    }
}
