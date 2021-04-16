using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI collectedGems;
    private int gemstones;
    bool gamehasended = false;

    public Slider slider;
    public int maxHealth = 100;
    public int currentHealth;

  


    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreBoard(0);
        currentHealth = maxHealth;
        SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (gemstones >= 250)
        {
            EndGame();
        }

        
    }

    public void UpdateScoreBoard(int gemsToAdd)
    {
        gemstones += gemsToAdd;
        if(gemstones < 0)
        {
            gemstones = 0;
        }
        collectedGems.text = "Gemstones " + gemstones;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        
    }

    public void TakeDamage(int damage)
        {
        currentHealth -= damage;
            SetHealth(currentHealth);

        if (currentHealth == 0)
        {
            GameOverLost();
        }
    }

    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            GameOverWin();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOverWin()
    {
        SceneManager.LoadScene(2);
    }

    public void GameOverLost()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
