using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;
    public GameObject CollisionPanel;
    public int theScore;
    public Text scoreValue;

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
            //Had to add the if statement here because the EndLevel Invisible Block isTrigger.
            // So when the player collides with the endlevel Block the score goes up by 1.
            // Cant have that now can we.
            theScore += 1;

            scoreValue.GetComponent<Text>().text = theScore.ToString();

        }

    }
}
