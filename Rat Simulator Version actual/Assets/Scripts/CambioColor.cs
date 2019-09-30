using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().ColorNegro(); // Un metodo de extension method que hace un cambio de color al iniciar 
    }

}
