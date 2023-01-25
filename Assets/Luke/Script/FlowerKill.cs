using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerKill : MonoBehaviour
{
    public GameObject flower;
    public GameObject sissornoise;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sissors")
        {
            sissornoise.SetActive(true);
            Plant();
        }
    }

    public void Plant()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        flower.SetActive(false);
        Debug.Log("kill flower");
        sissornoise.SetActive(false);
    }
}