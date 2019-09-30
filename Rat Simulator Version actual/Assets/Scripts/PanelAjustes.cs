using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelAjustes : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PanelVolumen;
    public GameObject PanelCreditos;
    public Slider Voliume;
    public AudioSource SonidoMenu;
    bool Rectificar;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        PanelVolumen.SetActive(false);
        PanelCreditos.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Rectificar == true)
        {
            Panel.SetActive(true);
        }
        if (Rectificar == false)
        {
            Panel.SetActive(false);
        }
    }

    public void AbrirAjustes()// Muestra el panel de ajustes
    {
        Rectificar = true;
    }
    public void BackAjustes() // Boton de regreso
    {
        Rectificar = false;
    }
    public void Volumen() // Slider de volumen
    {
        SonidoMenu.volume = Voliume.value;
    }
    public void Mostrarslider() // Activar slider del volumen
    {
        PanelVolumen.SetActive(true);
    }
    public void BackToPanelAjustes() // Boton regreso
    {
        PanelVolumen.SetActive(false);
        PanelCreditos.SetActive(false);
    }
    public void MostrarCreditos()// Boton de Creditos
    {
        PanelCreditos.SetActive(true);


    }
}
