using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlowerColl : MonoBehaviour
{
    
    public GameObject plantNarration;
    public GameObject startNarration;
    public GameObject startPanel;
    public GameObject textPanel;

    // Start is called before the first frame update
    void Start()
    {
        plantNarration.SetActive(false);
        startNarration.SetActive(true);
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            plantNarration.SetActive(true);
            textPanel.SetActive(true);
            //Debug.Log("flower talk");
            startNarration.SetActive(false);
            startPanel.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            plantNarration.SetActive(false);
            textPanel.SetActive(false);
            //Debug.Log("flower talk");
        }
    }
}
