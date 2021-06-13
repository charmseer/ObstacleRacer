using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Transform player;
    public Text DistanceText;
    float playerPosition, offset = -4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.position.z;
        if(player.position.y >=0) // When position.y < 0 player falls off the edge and we need the score to stop.
        {
            //scoreText.text = player.position.z.ToString("0");
            DistanceText.text = (playerPosition + offset).ToString("F1")+ "m";
        }

        //scoreText.text = player.position.z.ToString("0"); // Code above stops score from updating if player falls off the edge
    }
}
