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
        if(collisionInfo.collider.tag == "Obstacle")
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
        theScore += 1;
        
        scoreValue.GetComponent<Text>().text = theScore.ToString() + "/5";
    }
}
