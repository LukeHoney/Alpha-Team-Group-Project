using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaterEffect : MonoBehaviour
{
    public GameObject wateringCan;
    public ParticleSystem waterParticles;
    public InputActionReference thrustAction;
    public GameObject waternoise;

    public bool plantArea;

    void Start()
    {
        waterParticles.Stop();
        waternoise.SetActive(false);
        plantArea = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlantArea")
        {
            plantArea = true;
            Debug.Log("In water area");
        }
    }

    private void Update()
    {
        if (thrustAction.action.IsPressed())
        {
            if (plantArea == true)
            {
                waterParticles.Play();
                waternoise.SetActive(true);
            }
            
        }
        else
        {
            waterParticles.Stop();
            waternoise.SetActive(false);
        }
    }
    //// Update is called once per frame
    //void Update()
    //{
    //    if (wateringCan.transform.rotation.eulerAngles.x <= -140f)
    //    {
    //        Debug.Log("Water is free");
    //    }


    //}
    //public void EndGameOnDegrees()
    //{
    //    float min = -140f;
    //    float max = -200f;

    //    float angle = Vector3.Angle(Vector3.up, transform.up);


    //    if (angle < min || angle > max)
    //    {
    //        Debug.Log("Water is free EndGame");
    //    }
    //}
}
