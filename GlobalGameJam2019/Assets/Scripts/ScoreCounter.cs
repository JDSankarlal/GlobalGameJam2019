using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    public static float playerScore = 0;
	// Use this for initialization
    UnityEngine.UI.Text score;
	void Start ()
    {
        score = GetComponent<UnityEngine.UI.Text>();
        playerScore = 0;
        InvokeRepeating("AddScore", 1.0f, 1.0f);

    }
	
	// Update is called once per frame
	void AddScore()
    {
        playerScore++;
        score.text = "Score: " + playerScore ;
	}
}
