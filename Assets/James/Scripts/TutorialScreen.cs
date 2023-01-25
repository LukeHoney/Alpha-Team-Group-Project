using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScreen : MonoBehaviour
{
    public Canvas tutorialCanvas;
    public Button startButton;
    public AudioSource startAudioSource;

    private void Start()
    {
        tutorialCanvas.gameObject.SetActive(true);
        startButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        tutorialCanvas.gameObject.SetActive(false);
        startAudioSource.gameObject.SetActive(true);
    }
}
