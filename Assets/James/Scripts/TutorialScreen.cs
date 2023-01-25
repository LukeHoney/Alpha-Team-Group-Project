using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScreen : MonoBehaviour
{
    public GameObject tutorialCanvas;
    public Button startButton;
    public AudioSource startAudioSource;
    public Fly flyingScript;

    void Start()
    {
        tutorialCanvas.SetActive(true);
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);
        
    }

    public void StartGame()
    {
        Debug.Log("Button Works");

        tutorialCanvas.SetActive(false);
        startAudioSource.Play();
        flyingScript.enabled = true;
    }
}
