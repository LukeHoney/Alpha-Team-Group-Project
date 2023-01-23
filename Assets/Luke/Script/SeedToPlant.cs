using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedToPlant : MonoBehaviour
{
    public GameObject seed;
    public GameObject plant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    public void Plant()
    {
        plant.SetActive(true);
        seed.SetActive(false);
    }

}
