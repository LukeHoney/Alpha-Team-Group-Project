using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button mainMenuButton;
    
    public GameObject mainPanel;
    public GameObject selectPanel;
    public GameObject creditPanel;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = mainMenuButton.GetComponent<Button>();
        btn.onClick.AddListener(Panelmain);
    }
    
        
    

public void Panelmain()
    {
        mainPanel.SetActive(true);
        selectPanel.SetActive(false);
        creditPanel.SetActive(false);
    }
}
