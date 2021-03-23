using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public int Score;
    public GameManager scoreboard;
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

        if (other.gameObject.tag == "Collectible")
        {
            Score += 25;
            collectible.SetActive(false);
            Destroy(GameObject.FindWithTag("Collectible"));
            scoreboard.UpdateScoreBoard(25);
            
        }
        
        
    }

   
}
