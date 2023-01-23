using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPath : MonoBehaviour
{
    public Transform GetWaypoint(int waypointIndex)
    {
        return transform.GetChild(waypointIndex);
    }

    public int GetNextWaypointIndex(int currentWaypointIndex)
    {
        int nextWaypointpointIndex = currentWaypointIndex + 1;

        if (nextWaypointpointIndex == transform.childCount)
        {
            nextWaypointpointIndex = 0;
        }

        return nextWaypointpointIndex;
    }
}
