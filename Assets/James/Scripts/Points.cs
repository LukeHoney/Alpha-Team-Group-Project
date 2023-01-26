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
        if (playerScore < 3)
        {
            scoreText.text = "Flowers harvested " + playerScore.ToString();
        }
        else if (playerScore >= 3)
        {
            scoreText.text = "Flowers Harvested " + playerScore.ToString() + " Return To Hive";
        }
    }
    public void OnTriggernEnter(Collider other)
    {
        if (other.tag == "Hive")
        {
            Debug.Log("Hit Hive");

            if (playerScore >=3)
            {
                playerScore = 0;
            }

        }
    }


}