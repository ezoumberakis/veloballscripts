using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    public Transform player;
    public GameObject boost;

    public float minX;
    public float maxX;
    public float Ydistance;
    private float Xrange;
    private float playerY;

    public float TimeBetweenSpawn;
    private float SpawnTime;

    void Update()
    {
        Xrange = Random.Range(minX, maxX);
        playerY = player.position.y;

        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        Instantiate(boost, new Vector3(Xrange, playerY - Ydistance, 0), transform.rotation);
        Invoke("DestroySpawns", 120);
        Invoke("DestroyBoosts", 240);
    }

    void DestroySpawns()
    {
        Destroy(GameObject.Find("coin(Clone)"));
        
    }

    void DestroyBoosts()
    {
        Destroy(GameObject.Find("SpeedBoost(Clone)"));
        Destroy(GameObject.Find("SlowBoost(Clone)"));
        Destroy(GameObject.Find("StopSpeed(Clone)"));
        Destroy(GameObject.Find("GravSlow(Clone)"));
    }

}
