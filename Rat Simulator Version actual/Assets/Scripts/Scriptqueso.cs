using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scriptqueso : MonoBehaviour
{
    public bool ComerQueso = true;
    public GameObject QuesoObject;
    public GameObject sliderqueso;
    public Slider quesoslider;
    public GameObject Win;
    public RatController claseraton;
    float QuesosParaSegundoNivel = 10;
    bool Evento;
    public Slider SliderRedondo;

    void Start()
    {
        QuesoObject.SetActive(true); Win.SetActive(false); // por defecto empiezan falsos para que no interrumpan nada

    }

    // Update is called once per frame
    void Update()
    {

        SliderRedondo.value += Time.deltaTime ; // Slider en forma de reloj para simular un aumento de velocidad al comer un queso
        if (SliderRedondo.value <= 49) // mientras el slider este en este valor la velocidad va aumentar
        {
            RatController.Speed = 5f;
        }
        if (SliderRedondo.value >= 50) // cuando se completa el slider la velocidad del raton vuelve a la normalidad
        {
            RatController.Speed = 2.8f;
        }

        if (ComerQueso == false) // Disminucion del valor del slider para controlar que se complete de comer todo el queso
        {
            quesoslider.value -= Time.deltaTime;
        }
        if (quesoslider.value <= 0) // Cuando el slider llega a 0 ,Se llama el metodo sumadorScore para sumar score y sumar cantidad de quesos
        {
            ScoreManager.instance.StartCoroutine("SumadorScore");
            ComerQueso = true; // se hace true que en este caso seria al contrario para que a no siga ejecutandose
            claseraton.canMove = true; // hace que ya me pueda mover
            QuesoObject.SetActive(false); // se desactiva el gameObject del queso
            sliderqueso.SetActive(false); // se desactiva el slider
            quesoslider.value = 1; // se resetea el valor del slider
            claseraton.numquesos++; // se suma la cantidad de quesos
            SliderRedondo.value = 0; // se hace el slider 0 para que empiece a darle mas velocidad
        }

        if (claseraton.numquesos >= QuesosParaSegundoNivel) // Si la cantidad de quesos es mayor o igual a 10 se podra avanzar al segundo nivel
        {
            QuesosParaSegundoNivel = 20;
            claseraton.numquesos = 10;
            Eventos.VoidWinActive();
        }
    }

    private void OnTriggerEnter(Collider other) // Detectar colision del raton y el queso
    {
        if (other.gameObject.tag == "Player")
        {
            Eventos.ClaseClick(); // Llama al meotdo que ejecuta el sonido al coger el queso
            Evento = true;
        }
    }

    void ActiveWin() //activar panel de ganar
    {
        Win.SetActive(true);
    }

    void ComerQuesito(){ // Este metodo activa slider , hace que no pueda moverme y hace un booleano falso para que haga algo
        if (Evento){
            ComerQueso = false; // se hace falso para disminuir el slider
            claseraton.canMove = false; // no me deja mover
            sliderqueso.SetActive(true); // activa el slider
            quesoslider.value = 3; // le da valor por defecto
            Evento = false; // se cancela este if para que no entre en un ciclo
        }
    }
    private void OnEnable() // Suscripcion de metodos a eventos
    {
        Eventos.CogerQueso += ComerQuesito; 
        Eventos.WinActive += ActiveWin;
    }
    private void OnDisable()
    {
        Eventos.CogerQueso -= ComerQuesito;
        Eventos.WinActive -= ActiveWin;
    }






}
