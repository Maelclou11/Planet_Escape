using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefabs;

    public float timeBetweenRounds = 15f;

    private int cash = 0;
    private float timeToDispawn = 10f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBlocks();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnBlocks ()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); // 0 a 4 OU 0 a 1

        for (int i = 0; i < spawnPoints.Length; i++) // 
        {
            if (randomIndex != i) // 
            {
                Instantiate(blockPrefabs, spawnPoints[i].position, Quaternion.identity);
                cash++;
            }
        }

        
        if (Time.time >= timeToDispawn)
        {
            Destroy(gameObject);
            timeToDispawn = Time.time + timeToDispawn;
        }
        
    }

    public int GetCash()
    {
        return cash;
    }
}
