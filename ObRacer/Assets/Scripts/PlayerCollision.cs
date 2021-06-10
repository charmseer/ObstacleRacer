using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;
    public GameObject CollisionPanel;

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
    

}
