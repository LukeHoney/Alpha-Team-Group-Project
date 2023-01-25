using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polloniation : MonoBehaviour
{
    public float pollenCollectSpeed = 1.0f;
    public float pollenCarryCapacity = 10.0f;
    public float pollenToHoneyConversionRate = 0.1f;
    public GameObject hive;

    private float currentPollenAmount = 0.0f;
    private bool carryingPollen = false;

    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower"))
        {
            // Check if we're close to a flower and if we have room to collect more pollen
            if (currentPollenAmount < pollenCarryCapacity)
            {
                // Collect pollen from the flower
                currentPollenAmount += pollenCollectSpeed * Time.deltaTime;
                carryingPollen = true;
            }
        }
        if (collision.gameObject.CompareTag("Hive"))
        {   
            if (carryingPollen == true)
        {
            // Convert pollen to honey and deposit it in the hive
            currentPollenAmount -= pollenToHoneyConversionRate * Time.deltaTime;
            if (currentPollenAmount <= 0)
            {
                currentPollenAmount = 0;
                carryingPollen = false;
            }
        }
        }
    }
}

