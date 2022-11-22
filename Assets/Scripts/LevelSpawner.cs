using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    private GameManager gameManager;
    private GameObject lifeBall;
    private bool hasInstantiate;

    // Start is called before the first frame update
    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        lifeBall = GameObject.FindGameObjectWithTag("LifeBall");
        hasInstantiate = false;

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float distanceFromLifeBall = gameObject.transform.position.y - gameManager.distanceToSpawn;

        if (distanceFromLifeBall <= lifeBall.transform.position.y && hasInstantiate == false)
        {
            Instantiate(gameManager.OneUniqueLevel(), gameObject.transform.position, Quaternion.identity);
            hasInstantiate = true;
        }
    }
}
