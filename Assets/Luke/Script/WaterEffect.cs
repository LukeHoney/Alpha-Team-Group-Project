using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEffect : MonoBehaviour
{
    public GameObject wateringCan;


    // Update is called once per frame
    void Update()
    {
        if (wateringCan.transform.rotation.eulerAngles.x <= -140f)
        {
            Debug.Log("Water is free");
        }


    }
    public void EndGameOnDegrees()
    {
        float min = -140f;
        float max = -200f;

        float angle = Vector3.Angle(Vector3.up, transform.up);


        if (angle < min || angle > max)
        {
            Debug.Log("Water is free EndGame");
        }
    }
}
