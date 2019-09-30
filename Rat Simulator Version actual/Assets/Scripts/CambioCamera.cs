using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamera : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;

    private void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) // Se llaman eventos especificos para ejectar un metodo
    {
        if (other.gameObject.tag == "Pared")
        {
            Eventos.VoidCollisionPared(); 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Pared")
        {
            Eventos.VoidExitPared();
        }
    }

    void ColisionPared() // Transicion entre camaras para cuando se colisiona con la pared para prevenir que la camara se vea detras de las paredes
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
    }
    void ExitPared()
    {
        Camera2.SetActive(false);
        Camera1.SetActive(true);
    }
    private void OnEnable()
    {
        Eventos.ParedCollision += ColisionPared;
        Eventos.ParedExit += ExitPared;
    }
    private void OnDisable()
    {
        Eventos.ParedExit -= ExitPared;
        Eventos.ParedCollision -= ColisionPared;
    }
}
