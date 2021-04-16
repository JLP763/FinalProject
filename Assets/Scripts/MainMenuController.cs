using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void Help()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        Debug.Log("You have quit the game!");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
