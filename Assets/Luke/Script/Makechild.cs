using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makechild : MonoBehaviour
{
    public GameObject newWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        newWaypoint.transform.parent = this.transform;
    }
}
