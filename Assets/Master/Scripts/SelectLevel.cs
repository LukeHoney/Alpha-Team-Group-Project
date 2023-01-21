using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour
{
    public Button selectButton;
    public GameObject mainPanel;
    public GameObject selectPanel;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = selectButton.GetComponent<Button>();
        btn.onClick.AddListener(Panelchange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Panelchange()
    {
        mainPanel.SetActive(false);
        selectPanel.SetActive(true);

    }
}
