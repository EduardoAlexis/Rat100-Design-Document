using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class perseguir : MonoBehaviour
{

    public GameObject rata;
    public GameObject corrutina;
    public GameObject Aquien;
    public NavMeshAgent gatoo;

   
    void Start()
    {
        Aquien = corrutina;
    }


    void Update()
    {
        gatoo.SetDestination(Aquien.transform.position); // El modelo del gato , sigue a un objeto vacio el cual tiene la corrutina
    }

    private void OnTriggerEnter(Collider other) // Si entra en la vista del raton , lo sigue a el, pero si se encuentra un obstaculo se va a seguir con la corrutina
    {
        if (other.gameObject.tag == "Player")
        {
            Eventos.VoidColliPlayer();
        }
        if (other.gameObject.tag == "obs")
        {
            Eventos.VoidColliObs();
        }
    }
    void TriggerPlayer()
    {
        Aquien = rata;
    }
    void TriggerObs()
    {
        Aquien = corrutina;
    }

    private void OnEnable() // Suscripciones de los metodos por los cuales decide a quien seguir
    {
        Eventos.PlayerCollision += TriggerPlayer;
        Eventos.ObsCollision += TriggerObs;
    }
    private void OnDisable()
    {
        Eventos.ObsCollision -=TriggerObs;
        Eventos.PlayerCollision -=TriggerPlayer;

    }
}
