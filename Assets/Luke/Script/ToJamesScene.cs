using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToJamesScene : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bee")
        {
            LoadJames();
            Debug.Log("Collider with bees");
        }
    }

    public void LoadJames()
    {
        StartCoroutine(Wait());
       
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("James");
    }
}
