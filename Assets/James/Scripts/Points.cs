using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public float playerScore;
    public float honey;



    public TMP_Text scoreText;
    public TMP_Text honeyText;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        honey = 0;

        scoreText.text = "Flowers Harvested " + playerScore.ToString();
        honeyText.text = "Honey Made " +honey.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScore < 3)
        {
            scoreText.text = "Flowers harvested " + playerScore.ToString();
        }
        else if (playerScore >= 3)
        {
            scoreText.text = "Flowers Harvested " + playerScore.ToString() + " Return To Hive";
        }
        honeyText.text = "Honey Made " + honey.ToString();


        }
    }
