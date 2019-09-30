using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbarPalito1 : MonoBehaviour
{
    public Animator palo;
    GameObject Player;
    GameObject Palo;
    public GameObject BotonTirar;
    float distance;

    void Start()
    {
        Player = GameObject.FindWithTag("Player"); // Para no arrastrar nada desde el inspector se buscan los gameobjects con tags especificos
        Palo = GameObject.FindWithTag("Palo2");
        BotonTirar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(Player.transform.position, palo.transform.position); //Se encuentra la distancia entre el raton y el palito a tumbar
        if (distance < 3)
        {
            BotonTirar.SetActive(true);
        }
        else
        {
            BotonTirar.SetActive(false);
        }

    }
    public void PaloNum1() {                    // Lo que permite esto es que al acercarme me aparezca un boton con el cual el palito hace la funcion de rampla
        palo.AnimatorrPalo();                    // Extension method 
        BotonTirar.SetActive(false);
        this.enabled = false;
    }


}
