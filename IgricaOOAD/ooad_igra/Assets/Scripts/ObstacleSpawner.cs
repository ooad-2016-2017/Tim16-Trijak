using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    public float[] Lanes;

    public float ObstacleDistance = 100;
    
    public Transform player;
    public Transform obstaclePrefab;
    public Transform powerupPrefab;

    private float lastSpawnDistance = 0;

    public float yPosOffset = 1;

    public float spawnOffset = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (!player) return;

	    float playerZ = player.position.z;

	    if (playerZ - lastSpawnDistance >= ObstacleDistance)
	    {
	        Spawn();
	        lastSpawnDistance = playerZ;
	    }
	}

    void Spawn()
    {
        int cnt = Random.Range(1, 3);
        
        List<float> positions = new List<float>();
        foreach ( var lanePos in Lanes ) positions.Add(lanePos);

        for (int i = 0; i < cnt; i++)
        {
            int selected = Random.Range(0, positions.Count);

            float spawnX = positions[selected];
            positions.RemoveAt(selected);

            Transform spawned = (Transform)Instantiate(
                obstaclePrefab,
                new Vector3(spawnX, yPosOffset, player.position.z + ObstacleDistance + spawnOffset),
                Quaternion.identity
            );

            spawned.GetComponent<Obstacle>().player = player;


            player.GetComponent<Player>().OnDeath += spawned.GetComponent<Obstacle>().onDeath;
        }

        foreach (var spawnX in positions)
        {

            Transform spawned = (Transform)Instantiate(
                powerupPrefab,
                new Vector3(spawnX, yPosOffset, player.position.z + ObstacleDistance + spawnOffset),
                Quaternion.Euler(powerupPrefab.rotation.eulerAngles)
            );

            spawned.GetComponent<Powerup>().player = player;
        }
    }
}
