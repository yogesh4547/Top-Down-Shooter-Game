using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.GetMouseButtonDown(0))
        {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpwaPoints = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefabs[0], spawnPoints[randSpwaPoints].position, transform.rotation);

        }
        
    }
}
