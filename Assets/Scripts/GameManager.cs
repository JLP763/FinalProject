using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI collectedGems;
    private int gemstones;
    
    // Start is called before the first frame update
    void Start()
    {
                UpdateScoreBoard(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreBoard(int gemsToAdd)
    {
        gemstones += gemsToAdd;
        collectedGems.text = "Gemstones: " + gemstones;
    }
}
