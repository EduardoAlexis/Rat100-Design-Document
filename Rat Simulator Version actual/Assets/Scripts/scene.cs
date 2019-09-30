using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using TMPro;

public class scene : MonoBehaviour
{
    public GameObject Panelajustes; public GameObject Panel;
    public GameObject BottonConfig;
    public GameObject BottonConfig2;
    public GameObject Win;
    public AudioSource AudioJuego;
    public Slider Juegoslider;
    GameObject ReffRatica;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AudioController.FadeOut(AudioJuego,2));
        Panelajustes.SetActive(false); Panel.SetActive(false); BottonConfig.SetActive(true);
        BottonConfig2.SetActive(false);
        ReffRatica = GameObject.FindWithTag("Player");
    }
    private void Update()
    {
        AudioJuego.volume = Juegoslider.value;
    }

                             // Estos metodos son los que se llaman al oprimir un boton 
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Play2()
    {
        SceneManager.LoadScene(2);
    }
    public void Play3()
    {
        SceneManager.LoadScene(3);
    }
    public void Play4()
    {
        SceneManager.LoadScene(4); // Cargar escenas
    }

    public void Home()
    {
        SceneManager.LoadScene(0); // Cargar menu, y reiniciar timeScale
        Time.timeScale = 1.0f;
    }
    public void Volver() // Botones de regreso
    {
        Panelajustes.SetActive(false);
    }
    public void Ajustes()
    {
        Panelajustes.SetActive(true);
    }
    public void Config() // Boton de configuracion
    {
        BottonConfig.SetActive(false);
        BottonConfig2.SetActive(true);
        Panel.SetActive(true);
        Time.timeScale = 0;

    }
    public void Config2()
    {
        BottonConfig2.SetActive(false);
        BottonConfig.SetActive(true);
        Panel.SetActive(false);
        Time.timeScale = 1;
    }


    }
