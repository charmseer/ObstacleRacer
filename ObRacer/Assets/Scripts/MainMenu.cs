using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("World1Level1");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("World1Level2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("World1Level3");
    }

    public void QuitGame()
    {
        Debug.Log("Player has Quit the Game");
        Application.Quit();
    }
}
