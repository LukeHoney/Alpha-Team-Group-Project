using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPoint : MonoBehaviour
{
    public Points playerScoreScript;
    public float flowerscore;

    public bool inTheFlower;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   
    public void OnTriggerEnter(Collider other) // This command triggers an event when an object touchs the Flower Cell
    {
        if (other.tag == "PC") // This command checks if the object that touchs the Flower Cell is the "PC"
        {
            inTheFlower = true; // Thic command makes the bool true

            StartCoroutine(Pollon()); // This command starts the coroutine "Pollon()"
        }
    }
        public IEnumerator Pollon()
        {
            if (inTheFlower == true) // This is a check to see if the bool is true
            {
                if (playerScoreScript.playerScore < 3)
                {
                    playerScoreScript = GameObject.Find("PlayerModel").GetComponent<Points>();
                    playerScoreScript.playerScore = playerScoreScript.playerScore + flowerscore;
                    yield return new WaitForSeconds(1f);
                    Debug.Log(playerScoreScript.playerScore);
                }
                else 
                {
                }
            }
            else
            {
                StopCoroutine(Pollon()); // This command stops the coroutine "Pollon()"
            }
        }
        public void OnTriggerExit(Collider other) // This command triggers when an object leaves the Flower Cell
        {
            if (other.tag == "PC") // This command is a check to ensure on the "PC" can interact with the Flower Cell
            {
                inTheFlower = false; // This sets the bool as false
            }
        }
    }

