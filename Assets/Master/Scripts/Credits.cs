using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Button creditsButton;
    public GameObject mainPanel;
    public GameObject creditPanel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = creditsButton.GetComponent<Button>();
        btn.onClick.AddListener(Panelcredit);
    }

    public void Panelcredit()
    {
        mainPanel.SetActive(false);
        creditPanel.SetActive(true);
    }
}
