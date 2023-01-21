using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AntaineStart : MonoBehaviour
{
    public Button antaineButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = antaineButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadAntaine);
    }

    public void LoadAntaine()
    {
        SceneManager.LoadScene("Antaine");
    }
}
