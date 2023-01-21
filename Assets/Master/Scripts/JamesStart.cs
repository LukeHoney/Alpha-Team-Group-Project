using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JamesStart : MonoBehaviour
{
    public Button jamesButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = jamesButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadJames);
    }

    public void LoadJames()
    {
        SceneManager.LoadScene("James");
    }
}
