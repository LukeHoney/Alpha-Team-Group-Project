using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedToPlant : MonoBehaviour
{
    public GameObject seed;
    public GameObject plant;
    public GameObject plantAudio;
    public GameObject beeLocation;

    public Makechild makeChildScript;
    public MovingBee movingBeeScript;
    public BeeFinalLocation beeFinalLocationScript;
    public AudioEnd audioEndScript;

    public bool plantArea;

    private void Start()
    {
        plantArea = false;
        plantAudio.SetActive(false);
        //orginal bee waypoint
        //beeLocation.SetActive(false);
        //makeChildScript.enabled = false;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlantArea")
        {
            plantArea = true;
            //Debug.Log("In plant area");
        }
        

        if (other.tag == "Water")
        {
            if (plantArea == true)
            {
                //Debug.Log("Water and seed");
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
        plantAudio.SetActive(true);
        plant.SetActive(true);
        seed.SetActive(false);
        audioEndScript.enabled = true;
        movingBeeScript.enabled = false;
        beeFinalLocationScript.enabled = true;

        //beeLocation.SetActive(true);
        //makeChildScript.enabled = true;
    }

}
