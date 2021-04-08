using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public int Score;
    public GameManager scoreboard;
    public int Health;

    //public GameObject collectible = GameObject.FindWithTag("Collectible");
    //public static bool collected = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
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
            scoreboard.UpdateScoreBoard(25);
            
        }else if (other.gameObject.tag == "Enemy")
        {
            Health -= 1;
            
            enemy.SetActive(false);
            Destroy(GameObject.FindWithTag("Enemy"));
            scoreboard.UpdateScoreBoard(-100);
        }
        
        
    }

   
}
