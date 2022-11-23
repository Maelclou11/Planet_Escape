using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBall : MonoBehaviour
{
    public GameObject niceTry;
    public bool isDead = false;
    public Animation flyingAnimation;

    private Cash cash;
    private Player player;
    private Animator animator;
    private ParticleSystem particleSystem;


    private void Start()
    {
        particleSystem = gameObject.GetComponent<ParticleSystem>();
        cash = FindObjectOfType<Cash>();
        animator = gameObject.GetComponent<Animator>();
        player = FindObjectOfType<Player>();
        particleSystem.Pause();
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
        particleSystem.Play();
    }

}
