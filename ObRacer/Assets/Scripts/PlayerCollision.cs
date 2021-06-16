using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement; // Gets the player's Movement Script
    public GameObject CollisionPanel; // To bring up the Panel on Collision
    public int theScore; // To score the score
    public Text scoreValue; // On Screen Score Text, Updates live
    public Text scoreValueLvlEnd; // Score shown at the end of the Level
    public Text bestScoreValue; // High Score shown at the end of the level
    //public Text bestScoreValue2;

    private void Start()
    {
        //In the beginning check the Scene name and set the bestScoreValue based on 
        //the PlayerPref variable of the corresponding Scene
        if(SceneManager.GetActiveScene().name == "World1Level1")
        {
            bestScoreValue.text = PlayerPrefs.GetInt("World1Level1", 000).ToString();
        }
        if (SceneManager.GetActiveScene().name == "World1Level2")
        {
            bestScoreValue.text = PlayerPrefs.GetInt("World1Level2", 000).ToString();
        }

        if (SceneManager.GetActiveScene().name == "World1Level3")
        {
            bestScoreValue.text = PlayerPrefs.GetInt("World1Level3", 000).ToString();
        }
        //bestScoreValue.text = PlayerPrefs.GetInt("World1Level2", 000).ToString();

    }


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == ("Obstacle") )
        {
            movement.enabled = false;
            Invoke("CollisionPause", 1.5f);
            //FindObjectOfType<GameManager>().CollisionPause();
        }

    }
    void CollisionPause()
    {
        CollisionPanel.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Token")
        {
            //Had to add the if statement here because the EndLevel Invisible Block has 'isTrigger' enabled.
            // So when the player collides with the endlevel Block the score goes up by 1.
            // Cant have that now can we?
            theScore += 1;

            scoreValue.GetComponent<Text>().text = theScore.ToString() + " / ";
            scoreValueLvlEnd.GetComponent<Text>().text = theScore.ToString()+ " / ";

        }

        if (other.gameObject.tag == "EndLevelBlock")
        {
            //Had to put the HighScore Updater inside this block because
            //otherwise the Highscore updated even if the Player died
            //before reaching the EndLevelBlock. Now the HighScore will be
            //reset only after the Player Reaches the EndLevelBlock
            Debug.Log(theScore);
            if (SceneManager.GetActiveScene().name == "World1Level1")
            {
                if (theScore > PlayerPrefs.GetInt("World1Level1", 0))
                {
                    PlayerPrefs.SetInt("World1Level1", theScore);
                    bestScoreValue.text = theScore.ToString() + " / ";
                }
            }

            if (SceneManager.GetActiveScene().name == "World1Level2")
            {
                if (theScore > PlayerPrefs.GetInt("World1Level2", 0))
                {
                    PlayerPrefs.SetInt("World1Level2", theScore);
                    bestScoreValue.text = theScore.ToString() + " / ";
                }
            }

            if (SceneManager.GetActiveScene().name == "World1Level3")
            {
                if (theScore > PlayerPrefs.GetInt("World1Level3", 0))
                {
                    PlayerPrefs.SetInt("World1Level3", theScore);
                    bestScoreValue.text = theScore.ToString() + " / ";
                }
            }

        }

    }
}
