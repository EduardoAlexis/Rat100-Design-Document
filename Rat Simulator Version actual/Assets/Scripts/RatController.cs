using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RatController : MonoBehaviour {

    public TextMeshProUGUI Cuantosquesos;
    public TextMeshProUGUI Cuantosquesos2;
    public TextMeshProUGUI Cuantosquesos3;
    public Pointerenter Arribabot;
    public Pointerenter Abajobot;
    public Pointerenter Izquierdabot;
    public Pointerenter Derechabot;
    public GameObject Tally;
    public scene ReffScene;
    public Rigidbody Player;
    public AudioSource SonidoQueso;
    public float Force;

    [Range(1, 50)]
    public static float Speed;
    public Animator Miratica;

    public int numquesos;
    public bool canMove = true; 

    void Start () {
        Tally.SetActive(false);

    }

    void Update () {

        if (this.transform.position.y <= 0.7f)  // Esto hace que el raton no se unda en el piso 
        {
            transform.position += new Vector3(0,0.07f,0);
        }

        if (canMove)                                              //Controlador de movimiento , dentro de un if, para que se pueda mover o no
        {
            Miratica.SetBool("correr",false);
            if (Arribabot.ispressed || Input.GetKey(KeyCode.W))  //Si se presiona el boton y la tecla W
            {
                Abajo(); Miratica.SetBool("correr", true); // Animacion de correr
            }
            else
            {
                Miratica.SetBool("correr", false); // Si no se esta presionando el boton se devuelve a la animacion de idle
            }
            if (Abajobot.ispressed || Input.GetKey(KeyCode.S)) // Si se presiona el boton o la tecla S
            {
                Arriba(); Miratica.SetBool("correr", true); // Se hace la animacion de correr pero esta vez va hacia atras
            }
            if (Izquierdabot.ispressed || Input.GetKey(KeyCode.A)) // Si se presiona el boton o la tecla A se rota
            {
                Izquierda();  
            }
            if (Derechabot.ispressed || Input.GetKey(KeyCode.D))  // Si se presiona el boton o la tecla D se rota
            {
                Derecha();  
            }
            Cuantosquesos.text = numquesos.ToString(); //Muestra la cantidad de quesos que hay
            Cuantosquesos2.text = numquesos.ToString();
            Cuantosquesos3.text = numquesos.ToString();
        }
    }
    public void Arriba() // Controles en UI
    {
        transform.Translate(Vector3.forward * -Time.deltaTime * Speed);   // Movimiento
    }
    public void Abajo()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);  // Retroceso
    }
    public void Izquierda()
    {
        transform.Rotate(0, -2, 0);  //Rota a la izquierda
    }
    public void Derecha()
    {
        transform.Rotate(0, 2, 0);  // Rota a la derecha
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "gato")// Eventos de colision con gato para mostrar pantalla de perder  
        {
            Eventos.Colisiongatico();
        }
        if (other.gameObject.tag == "ForceUp") //colision con objeto que tiene un addforce simulando un salto
        {
            Eventos.VoidAddforce();
        }
    }
    void Sonido_Comer_Queso() // sonido al comer un queso
    {
        SonidoQueso.Play();
    }

    void AddForceUp() // fuerza de salto
    {
        Player.AddForce(transform.up * Force);
    }

    void Collision_Gato() // panel de perder
    {
        Tally.SetActive(true);
    }

    private void OnEnable() // Suscripcion de los metodos a los eventos
    {
        Eventos.CogerQueso += Sonido_Comer_Queso;
        Eventos.GatoCollision += Collision_Gato;
        Eventos.Fuerza_Saltar += AddForceUp;
    }
    private void OnDisable()
    {
        Eventos.CogerQueso -= Sonido_Comer_Queso;
        Eventos.GatoCollision -= Collision_Gato;
        Eventos.Fuerza_Saltar -= AddForceUp;

    }
}
