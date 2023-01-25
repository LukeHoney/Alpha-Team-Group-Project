using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    //    public float speed;
    //    public float changeDirectionInterval;
    //    private float timeSinceLastDirectionChange;
    //    private Vector3 direction;

    //    void Start()
    //    {
    //        timeSinceLastDirectionChange = 0f;
    //        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    //    }

    //    void Update()
    //    {
    //        timeSinceLastDirectionChange += Time.deltaTime;

    //        if (timeSinceLastDirectionChange >= changeDirectionInterval)
    //        {
    //            direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    //            timeSinceLastDirectionChange = 0f;
    //        }

    //        transform.position += direction * speed * Time.deltaTime;
    //    }
    //}
    public float speed = 10.0f;
    public Vector3 minBoundary = new Vector3(-5, 0, -5);
    public Vector3 maxBoundary = new Vector3(5, 0, 5);
    private Vector3 targetPosition;

    void Start()
    {
        // Set an initial random target position
        SetRandomTargetPosition();
    }

    void Update()
    {
        // Move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Look at the target position
        transform.LookAt(targetPosition);

        // If we've reached the target position, set a new one
        if (transform.position == targetPosition)
        {
            SetRandomTargetPosition();
        }

        // Ensure the GameObject stays within the set boundaries
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minBoundary.x, maxBoundary.x),
            Mathf.Clamp(transform.position.y, minBoundary.y, maxBoundary.y),
            Mathf.Clamp(transform.position.z, minBoundary.z, maxBoundary.z)
        );
    }

    private void SetRandomTargetPosition()
    {
        // Generate a random position within the set boundaries
        targetPosition = new Vector3(
            Random.Range(minBoundary.x, maxBoundary.x),
            Random.Range(minBoundary.y, maxBoundary.y),
            Random.Range(minBoundary.z, maxBoundary.z)
        );
    }
}