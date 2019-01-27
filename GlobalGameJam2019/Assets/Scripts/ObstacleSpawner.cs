using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public GameObject obstacle;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    float difficultyIncreaseTime=60;
    float bigTimer;
    float currentSpawnTime;
	// Use this for initialization

	
    private void Update()
    {
        currentSpawnTime += Time.deltaTime;
        bigTimer += Time.deltaTime;

        if (currentSpawnTime>=spawnTime)
        {
            Spawn();
            currentSpawnTime = 0;
        }

        if (bigTimer>=difficultyIncreaseTime)
        {
            spawnTime -= .5f;
            difficultyIncreaseTime -= 5;
            bigTimer = 0;
        }
    }
	
    // Update is called once per frame
	void Spawn()
    {
        Debug.Log("Spawn Time: " + spawnTime);
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(obstacle, spawnPoints[spawnPointIndex].position,spawnPoints[spawnPointIndex].rotation);
    }

}
