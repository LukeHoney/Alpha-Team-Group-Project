using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlowerColl : MonoBehaviour
{
    
    public GameObject plantNarration;
    public GameObject startNarration;

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
            //Debug.Log("flower talk");
            startNarration.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            plantNarration.SetActive(false);
            //Debug.Log("flower talk");
        }
    }
}
