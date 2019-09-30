using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI Textscore;
    public TextMeshProUGUI Textscoretally;
    public TextMeshProUGUI Textscorewin;
    int randomRange;
    bool Imprima;
    private int score;
    public int Score
    {
        get{ // Se acude a este metodo para no tener que llamar constantemente lo que se quiere hacer
            return score;
        }
        set{
            score = value;
            Textscore.text = "Score : " + Score.ToString("000");
            Textscoretally.text = "Score : " + Score.ToString("000");
            Textscorewin.text = "Score : " + Score.ToString("000");
        }
    }
    void Awake() // Se hace una unica instancia 
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }        
    }
    public IEnumerator SumadorScore() // Esto da un score random entre 100 - 200 cada vez que se termina de comer un queso
    {
        randomRange = Random.Range(100, 200);
        for (int i = 0; i < randomRange; i++)
        {
            Score ++;
            yield return new WaitForSeconds(0.001f);
        }
    }
    private void OnTriggerEnter(Collider other) // Se llama el metodo suscrito al evento
    {
        if (other.gameObject.tag == "Player")
        {
            Eventos.VoidSumarScore();
        }
    }
    void Suma_Score()
    {
        StartCoroutine("SumadorScore");
    }
    private void OnEnable()
    {
        Eventos.SumarScore += Suma_Score;
    }
    private void OnDisable()
    {
        Eventos.SumarScore -= Suma_Score;
    }
}
