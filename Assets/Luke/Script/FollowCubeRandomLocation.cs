using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCubeRandomLocation : MonoBehaviour
{
    //This Scripts puts a target cube in a random waypoint(set with the array) and then after wait time places the target in another location
    //This target is used for the selected npc to follow but that is active in the related NavMoveTarget Script

    public Transform[] spawnPoints;
    public GameObject cube1;
    public int spawnNumberLocation;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

        spawnpoint();

    }
    private void Update()
    {
        target = GameObject.Find("Following Cube (1)(Clone)");
    }
    public void spawnpoint()
    {
        spawnNumberLocation = UnityEngine.Random.Range(0, spawnPoints.Length);

        Instantiate(cube1, spawnPoints[spawnNumberLocation].transform.position, Quaternion.identity);

        StartCoroutine(Wait());
    }

    IEnumerator Wait()

    {
        yield return new WaitForSeconds(3);
        target.SetActive(false);
        spawnpoint();

    }
}

