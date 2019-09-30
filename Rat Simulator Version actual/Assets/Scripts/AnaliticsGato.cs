using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnaliticsGato : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Analytics.CustomEvent("gatoo"); // Envia nombres de eventos para almacenar variables que se quieran saber , por las cuales ha pasado el jugador
        }
    }

}
