using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = player.position + offset;

        //tried to destroy the player object and stop the camera
        //from moving when the player fell off the edge. Doesnt work!
        //Since this is in Update it keeps showing error in console that 
        //The assigned transform is destroyed. 
        /*        if (player.position.y >=-1.5)
                {
                    transform.position = player.position + offset;

                }
                */
        /*
                if(transform.position.y < -1.5)
                {
                    Destroy(gameObject);
                }   */
    }
}
