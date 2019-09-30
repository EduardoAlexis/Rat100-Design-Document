using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGravityy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().PonerGravedad(); // Extension methods , se le asigna a un objeto y se le activa la gravedad
    }


}
