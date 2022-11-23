using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableCube : MonoBehaviour
{
    private GameObject lifeBall;

    private void Start()
    {
        lifeBall = GameObject.FindGameObjectWithTag("LifeBall");
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.y <= lifeBall.transform.position.y + 16)
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
