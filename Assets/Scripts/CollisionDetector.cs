using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public int Score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Collectible")
        {
            Score += 25;
            Destroy(GameObject.FindWithTag("Collectible"));
        }
        
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 100, 100), Score.ToString());
    }
}
