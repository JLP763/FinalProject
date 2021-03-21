using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] gemstonePrefabs;
    public GameObject player;
    
    float spawnDistance = 20;
    private float startDelay = 2;
    private float spawnIntervalMin = 1.5f;
    private float spawnIntervalMax = 4.5f;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag("Player");
        InvokeRepeating("SpawnRandomGemstones", startDelay, Random.Range(spawnIntervalMin,spawnIntervalMax));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomGemstones()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 playerDirection = player.transform.forward;
        Quaternion playerRotation = player.transform.rotation;

        int gemstoneIndex = Random.Range(0, gemstonePrefabs.Length);
        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;

        Instantiate(gemstonePrefabs[gemstoneIndex], spawnPos, playerRotation);
    }
}
