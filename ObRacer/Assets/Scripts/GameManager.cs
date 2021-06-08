
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;

    public float restartDelay = 1f;
    public GameObject completeLvlUI;

    //Pause Button Panel
    public GameObject PauseMenuUI;

    //Esc Key Back button panel
    public GameObject EscMenuPanel;

    private void Update()
    {

        //If Player presses Esc button or back button on Android phones
        if (UnityEngine.InputSystem.Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Debug.Log("Escape Is Pressed");
            EscMenuPanel.SetActive(true);
            Time.timeScale = 0f;
            //ExitMenu();
        }

    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay) ;
        }

    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        //GameIsPaused = true;
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        //GameIsPaused = false;
    }

    public void EscResume()
    {
        EscMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        PauseMenuUI.SetActive(false);
        // When you hit Pause Time Scale freezes, So before you go to Main Menu you have to unfreeze it
        Time.timeScale = 1f;
        //GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }


    public void CompleteLevel()
    {
        Debug.Log("Level Won!");
        completeLvlUI.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Debug.Log("Player has chosen to quit the game");
        Application.Quit();
    }
}


