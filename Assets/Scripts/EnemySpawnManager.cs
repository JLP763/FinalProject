using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject player;
    //public AudioSource playerHit;
    

    float spawnDistance = 40;
    private float startDelay = 10;
    private float spawnIntervalMin = 10f;
    private float spawnIntervalMax = 20f;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        InvokeRepeating("SpawnEnemy", startDelay, Random.Range(spawnIntervalMin, spawnIntervalMax));
        //playerHit = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 playerDirection = player.transform.forward;
        Quaternion playerRotation = player.transform.rotation;

        int pirateIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;

        Instantiate(enemyPrefabs[pirateIndex], spawnPos, playerRotation);
    }

    public void OnCollisionEnter(Collision other)
    {
        //GameObject player = GameObject.FindWithTag("Player");
        //GetComponent<AudioSource>().Play();
        //playerHit.Play();
    }
}
