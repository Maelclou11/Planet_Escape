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
        if (transform.position.y > distanceFromLifeBall)
        {
            
        }
        Vector2 lol = new Vector2(0, 15);

        if (distanceFromLifeBall <= lifeBall.transform.position.y && hasInstantiate == false)
        {
            Instantiate(gameManager.OneUniqueLevel(), gameObject.transform.position, Quaternion.identity);
            int test = gameManager.LastLevelPlayedIndex();
            Debug.Log(gameManager.arrayLevels[test].transform.position);
            hasInstantiate = true;
        }
    }
}
