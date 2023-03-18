 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public Transform player;
    public GameObject obstacle;

    public float minX;
    public float maxX;
    public float Ydistance;
    private float Xrange;
    private float XRrange;
    private float playerY;

    public float TimeBetweenSpawn;
    private float SpawnTime;

    void Update()
    {
        Xrange = Random.Range(minX, maxX);
        XRrange = Random.Range(-30, 40);
        playerY = player.position.y;

        if(Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        Instantiate(obstacle, new Vector3(Xrange, playerY - Ydistance, 0), transform.rotation);
        Invoke("DestroySpawns", 120);
    }

    void DestroySpawns()
    {
        Destroy(GameObject.Find("obstacle(Clone)"));
    }
}
