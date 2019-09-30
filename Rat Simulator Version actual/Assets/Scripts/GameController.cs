using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Button inButton;
    public Button outButton;
    public AudioSource musicPlayer;

	// Use this for initialization
	void Start () {
        inButton.onClick.AddListener(DoFadeIn);
        outButton.onClick.AddListener(DoFadeOut);
    }
	
    void DoFadeIn() {
        StartCoroutine(AudioController.FadeIn(musicPlayer, 2f)); // Este GameController llama los metodos de AudioController para desvanecer o aumentar volumen
    }

    void DoFadeOut() {
        StartCoroutine(AudioController.FadeOut(musicPlayer, 1f));
    }

}
