using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Player has chosen to quit the game");
        Application.Quit();
    }
    public void MainMenu()
    {
        //GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }
}
