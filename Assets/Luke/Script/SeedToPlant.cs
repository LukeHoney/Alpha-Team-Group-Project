using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedToPlant : MonoBehaviour
{
    public GameObject seed;
    public GameObject plant;
    public GameObject water;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Water")
        {
            Debug.Log("Water and seed");
            Plant();
        }
    }
    public void Plant()
    {
        plant.SetActive(true);
        seed.SetActive(false);
    }

}
