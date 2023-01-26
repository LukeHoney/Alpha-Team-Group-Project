using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlowerColl : MonoBehaviour
{
    
    public GameObject plantNarration;

    // Start is called before the first frame update
    void Start()
    {
        plantNarration.SetActive(false);
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            plantNarration.SetActive(true);
            //Debug.Log("flower talk");
        }
    }
}
