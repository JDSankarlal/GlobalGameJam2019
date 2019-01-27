using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public GameObject obstacle;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Spawn()
    {

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(obstacle, spawnPoints[spawnPointIndex].position,spawnPoints[spawnPointIndex].rotation);
    }
}
