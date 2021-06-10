using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.y >=0)
        {
            scoreText.text = player.position.z.ToString("0");
        }

        //scoreText.text = player.position.z.ToString("0"); // Code above stops score from updating if player falls off the edge
    }
}
