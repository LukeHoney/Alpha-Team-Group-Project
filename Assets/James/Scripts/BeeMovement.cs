using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour //This is a script to allow the bees to fly randomly around the level
{
    public float speed = 10.0f;
    public Vector3 minBoundary = new Vector3(-50, 10, -50);
    public Vector3 maxBoundary = new Vector3(50, 40, 50);
    private Vector3 targetPosition;

    void Start()
    {
        SetRandomTargetPosition();
    }

    void Update()
    {
        // Move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        transform.LookAt(targetPosition);

        // When reached the target position, set a new one
        if (transform.position == targetPosition)
        {
            SetRandomTargetPosition();
        }

        // Ensure the Bee stays within the area
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minBoundary.x, maxBoundary.x),
            Mathf.Clamp(transform.position.y, minBoundary.y, maxBoundary.y),
            Mathf.Clamp(transform.position.z, minBoundary.z, maxBoundary.z));
    }

    private void SetRandomTargetPosition()
    {
        // Generate a random position within the boundaries
        targetPosition = new Vector3(
            Random.Range(minBoundary.x, maxBoundary.x),
            Random.Range(minBoundary.y, maxBoundary.y),
            Random.Range(minBoundary.z, maxBoundary.z));
    }
}