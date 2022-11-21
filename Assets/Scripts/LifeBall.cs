using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBall : MonoBehaviour
{
    public Animator animator;
    public Player player;
    public GameObject niceTry;
    public Cash cash;
    public bool isDead = false;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Die();
            animator.enabled = true;
        }
    }

    void Die()
    {
        FindObjectOfType<GameManager>().EndGame();
        player.enabled = false; // Turn off Player Movement when dying
        niceTry.SetActive(true); // Turn on the animation "Nice Try" after dying
        isDead = true;
        cash.enabled = false;
    }

}
