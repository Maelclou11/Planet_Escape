using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.attachedRigidbody.tag == "LifeBall" || collisionInfo.attachedRigidbody.tag == "Player")
        {
            gameManager.CompleteLevel();
        }
    }

}
