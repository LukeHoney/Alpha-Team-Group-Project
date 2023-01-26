using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoneyPoints : MonoBehaviour
{
public Points playerScoreScript;
public float honeyscore;

public AudioSource startAudioSource2;
public AudioSource startAudioSource3;
public AudioSource startAudioSource4;

public bool inTheHive;

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{

}

public void OnTriggerEnter(Collider other) // This command triggers an event when an object touchs the Hive Cell
{
    if (other.tag == "PC") // This command checks if the object that touchs the Hive Cell is the "PC"
    {
        inTheHive = true; // Thic command makes the bool true

        StartCoroutine(Honey()); // This command starts the coroutine "Pollon()"
    }
}
public IEnumerator Honey()
{
    if (inTheHive == true) // This is a check to see if the bool is true
    {
        if (playerScoreScript.playerScore <= 3)
        {
            playerScoreScript = GameObject.Find("PlayerModel").GetComponent<Points>();
            playerScoreScript.playerScore = 0;
            playerScoreScript.honey = playerScoreScript.honey + 1;
            yield return new WaitForSeconds(1f);
            Debug.Log(playerScoreScript.honey);


                if (playerScoreScript.honey == 1)
                {
                    startAudioSource2.Play();
                    Debug.Log("Playing Info");
                    yield return new WaitForSeconds(10f);
                }
                if (playerScoreScript.honey == 2)
                {
                    startAudioSource3.Play();
                    Debug.Log("Playing Info");
                    yield return new WaitForSeconds(10f);
                }
                if (playerScoreScript.honey == 3)
                {
                    startAudioSource4.Play();
                    Debug.Log("Playing Info");
                    yield return new WaitForSeconds(10f);
                }
                if (playerScoreScript.honey == 4)
                {
                    SceneManager.LoadScene("Master");
                    yield return new WaitForSeconds(10f);
                }

            }
        else
        {
        }
    }
    else
    {
        StopCoroutine(Honey()); // This command stops the coroutine "Honey()"
    }
}
public void OnTriggerExit(Collider other) // This command triggers when an object leaves the Flower Cell
{
    if (other.tag == "PC") // This command is a check to ensure on the "PC" can interact with the Flower Cell
    {
        inTheHive = false; // This sets the bool as false
    }
}
    }
