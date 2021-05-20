
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;

    public float restartDelay = 1f;
    public GameObject completeLvlUI;
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay) ;
        }
        
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
}
