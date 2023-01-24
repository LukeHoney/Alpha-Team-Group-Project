using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public float playerScore;

    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;

        scoreText.text = "Flowers Harvested " + playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Flowers harvested " + playerScore.ToString();
    }
    
}