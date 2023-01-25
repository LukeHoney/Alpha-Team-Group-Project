using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPoint : MonoBehaviour
{
    public Points playerScoreScript;
    public float flowerscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        playerScoreScript = GameObject.Find("PlayerModel").GetComponent<Points>();
        playerScoreScript.playerScore = playerScoreScript.playerScore + flowerscore;
        Debug.Log(playerScoreScript.playerScore);
    }
}
