using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Score : MonoBehaviour
{

    public Text scoreText;
    public static int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
       scoreText.text = ("Creatures Found: ") + playerScore.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.text = ("Creatures Found: ") + playerScore.ToString(); 
    }
}
