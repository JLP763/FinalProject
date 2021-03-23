using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI collectedGems;
    private int gemstones;
    bool gamehasended = false;
    
    // Start is called before the first frame update
    void Start()
    {
                UpdateScoreBoard(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gemstones >= 150)
        {
            EndGame();
        }
    }

    public void UpdateScoreBoard(int gemsToAdd)
    {
        gemstones += gemsToAdd;
        collectedGems.text = "Gemstones: " + gemstones;
    }

    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            GameOver();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
