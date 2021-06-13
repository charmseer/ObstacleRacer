using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    //public GameObject scoreText;
    //public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        //theScore += 50;
        Destroy(gameObject);
        //scoreText.GetComponent<Text>().text = theScore.ToString();
    }
}
