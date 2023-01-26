using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedToMarigold : MonoBehaviour
{
    public GameObject seed;
    public GameObject plant;
    public GameObject plantAudio;

    public bool plantArea;

    private void Start()
    {
        plantArea = false;
        plantAudio.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlantArea")
        {
            plantArea = true;
            Debug.Log("In plant area");
        }


        if (other.tag == "Water")
        {
            if (plantArea == true)
            {
                Debug.Log("Water and seed");
                Plant();
            }
        }
    }

    public void Plant()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        plant.SetActive(true);
        seed.SetActive(false);
        plantAudio.SetActive(true);
    }

}