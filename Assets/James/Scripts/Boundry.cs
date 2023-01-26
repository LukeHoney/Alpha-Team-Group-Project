using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public class TeleportOnCollision : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Wall")
            {
                Debug.Log("Hit Wall");

                Vector3 collisionDirection = other.transform.position - transform.position;
                Vector3 newPosition = transform.position - (collisionDirection.normalized * 1);
                transform.position = newPosition;
            }
        }
    }
}