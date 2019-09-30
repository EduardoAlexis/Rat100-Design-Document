using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class corrutinas : MonoBehaviour
{
    [Range(1, 16)]
    public float speed;
    public float number;

    public Vector3 inicial; public Vector3 destino; public Vector3 inicial2; public Vector3 destino2; // Posiciones en las cuales va el gato
    public Vector3 primero; public Vector3 segundo; public Vector3 tercer; public Vector3 cuarto; public Vector3 cinco; public Vector3 seis;
    public Vector3 c1; public Vector3 c2; public Vector3 c3; public Vector3 c4; public Vector3 c5; public Vector3 c6;


    void Start()
    {
        NumRandom();
    }

    void NumRandom()
    {
        number = Random.Range(1, 4);
    }

    void Update()
    {
        if (number == 1) // Obtiene un valor aleatorio entre 1 - 4 por el cual se accede a que comportamiento tiene el gato( hacia donde va )
        {
            print("Primera");
            StartCoroutine(Moverse(inicial, destino, speed));
            number = 0;
        }
        if (number == 2)
        {
            print("Segunda");
            StartCoroutine(Cuarto(c1, c2, speed));
            number = 0;
        }
        if (number == 3)
        {
            print("Tercera");
            StartCoroutine(Baño(primero, segundo, speed));
            number = 0;
        }

    }

    IEnumerator Moverse(Vector3 inicial, Vector3 destino, float speed) // Corrutinas de comportamiento
    {
        while (transform.position != inicial)
        {
            transform.position = Vector3.MoveTowards(transform.position, inicial, speed * Time.deltaTime);
            yield return null;
        }
        while (transform.position != destino)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino, speed * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(Moverse2(inicial2, destino2, speed));
    }


    IEnumerator Moverse2(Vector3 inicial2, Vector3 destino2, float speed)
    {
        while (transform.position != inicial2)
        {
            transform.position = Vector3.MoveTowards(transform.position, inicial2, speed * Time.deltaTime);
            yield return null;
        }
        while (transform.position != destino2)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino2, speed * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        NumRandom();
    }

    IEnumerator Cuarto(Vector3 c1, Vector3 c2, float speed)
    {
        while (transform.position != c1)
        {
            transform.position = Vector3.MoveTowards(transform.position, c1, speed * Time.deltaTime);
            yield return null;
        }
        while (transform.position != c2)
        {
            transform.position = Vector3.MoveTowards(transform.position, c2, speed * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(Cuarto2(c3, c4, speed));
    }
    IEnumerator Cuarto2(Vector3 c3, Vector3 c4, float speed)
    {
        while (transform.position != c3)
        {
            transform.position = Vector3.MoveTowards(transform.position, c3, speed * Time.deltaTime);
            yield return null;
        }
        while (transform.position != c4)
        {
            transform.position = Vector3.MoveTowards(transform.position, c4, speed * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(Cuarto3(c5, c6, speed));
    }
    IEnumerator Cuarto3(Vector3 c5, Vector3 c6, float speed)
    {
        while (transform.position != c5)
        {
            transform.position = Vector3.MoveTowards(transform.position, c5, speed * Time.deltaTime);
            yield return null;
        }
        while (transform.position != c6)
        {
            transform.position = Vector3.MoveTowards(transform.position, c6, speed * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        NumRandom();
    }


    IEnumerator Baño(Vector3 primero, Vector3 segundo, float speed)
    {
        while (transform.position != primero)
        {
            transform.position = Vector3.MoveTowards(transform.position, primero, speed * Time.deltaTime);
            yield return null;
        }
        while (transform.position != segundo)
        {
            transform.position = Vector3.MoveTowards(transform.position, segundo, speed * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(Baño2(tercer, cuarto, speed));
    }
    IEnumerator Baño2(Vector3 tercer, Vector3 cuarto, float speed)
    {
        while (transform.position != tercer)
        {
            transform.position = Vector3.MoveTowards(transform.position, tercer, speed * Time.deltaTime);
            yield return null;
        }
        while (transform.position != cuarto)
        {
            transform.position = Vector3.MoveTowards(transform.position, cuarto, speed * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(Baño3(cinco, seis, speed));
    }
    IEnumerator Baño3(Vector3 cinco, Vector3 seis, float speed)
    {
        while (transform.position != cinco)
        {
            transform.position = Vector3.MoveTowards(transform.position, cinco, speed * Time.deltaTime);
            yield return null;
        }
        while (transform.position != seis)
        {
            transform.position = Vector3.MoveTowards(transform.position, seis, speed * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        NumRandom();
    }


}
