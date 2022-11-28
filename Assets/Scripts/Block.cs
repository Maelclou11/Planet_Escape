using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    private GameObject lifeBall;
    private Cash cash;

    private void Start()
    {
        cash = FindObjectOfType<Cash>();
        lifeBall = GameObject.FindGameObjectWithTag("LifeBall");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Destroy every block after falling down 5 units under the life ball
        if (transform.position.y < lifeBall.transform.position.y + -5)
        {
            Destroy(gameObject);
            cash.AddCash(1);
        }

        // Enable the gravity when the life ball reach them from a distance of 8 units
        if (transform.position.y <= lifeBall.transform.position.y + 13)
        {
            gameObject.GetComponent<Rigidbody2D>().simulated = true;

        }
    }
}
