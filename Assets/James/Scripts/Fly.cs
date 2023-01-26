using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fly : MonoBehaviour //This is a script to make the player fly around the level
{
    private Vector3 thrustDirection;
    private Vector3 gravityDirection;

    public float currentFallSpeed;
    public float gravityAccelerationRate;
    public float gravityMaxSpeed;

    public float CurrentThrustPower;
    public float thrustAccelerationRate;
    public float thrustMaxSpeed;

    public InputActionReference thrustAction1;
    public InputActionReference thrustAction2;


    // Start is called before the first frame update
    void Start()
    {

        thrustDirection = Vector3.up;
        gravityDirection = Vector3.down;

    }

    // Update is called once per frame
    void Update()
    {
        if (thrustAction1.action.IsPressed()) //This makes the player move upwards
        {
            Debug.Log("Pressed");

            CurrentThrustPower += thrustAccelerationRate * Time.deltaTime;

            transform.position += thrustDirection * CurrentThrustPower * Time.deltaTime;
        }
        if (thrustAction2.action.IsPressed()) //This makes the player move downwards
        {
            if (transform.position.y > 1f)
            {
                currentFallSpeed += gravityAccelerationRate * Time.deltaTime;

                transform.position += gravityDirection * currentFallSpeed * Time.deltaTime;
            }    
            }
    }
    private void CalculateThrust() //This calculates the speed to move upwards
    {
        CurrentThrustPower += thrustAccelerationRate * Time.deltaTime;
        transform.position += thrustDirection * CurrentThrustPower * Time.deltaTime;
    }
    private void CalculateFall() //This calculates the speed to move downwards
    {
        currentFallSpeed -= gravityAccelerationRate * Time.deltaTime;
        transform.position -= gravityDirection * currentFallSpeed * Time.deltaTime;
    }

    //internal void SetActive(bool v)
    //{
    //    throw new NotImplementedException();
    //}
}