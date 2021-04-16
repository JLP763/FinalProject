﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public int Score;
    
    public GameManager gameManager;
    private AudioSource collisionAudio;
    public AudioClip playerHit;
    public AudioClip gemCollected;
    
    
    // Start is called before the first frame update
    void Start()
    {
        collisionAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        GameObject collectible = GameObject.FindWithTag("Collectible");
        GameObject enemy = GameObject.FindWithTag("Enemy");

        if (other.gameObject.tag == "Collectible")
        {
            Score += 25;
            collectible.SetActive(false);
            Destroy(GameObject.FindWithTag("Collectible"));
            gameManager.UpdateScoreBoard(25);
            collisionAudio.PlayOneShot(gemCollected, 1.0f);

        }
        else if (other.gameObject.tag == "Enemy")
        {
            enemy.SetActive(false);
            Destroy(GameObject.FindWithTag("Enemy"));
            gameManager.UpdateScoreBoard(-100);
            gameManager.TakeDamage(25);
            collisionAudio.PlayOneShot(playerHit, 2.0f);
        }

        
        
        
    }

   
}
