using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMoveTarget : MonoBehaviour
{
    //used for the selected npc to follow
    //Edited for continous changing target which happens in related FollowCubeRandomLocation Script

    public NavMeshAgent agent;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Following Cube (1)(Clone)").transform;
        agent.SetDestination(target.position);
    }
}


