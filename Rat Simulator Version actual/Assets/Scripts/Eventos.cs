using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventos : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction CogerQueso;
    public static event ClickAction GatoCollision;
    public static event ClickAction Fuerza_Saltar;
    public static event ClickAction ParedCollision;
    public static event ClickAction ParedExit;
    public static event ClickAction SumarScore;
    public static event ClickAction PlayerCollision;
    public static event ClickAction ObsCollision;
    public static event ClickAction WinActive;


    public static void ClaseClick() // Estos metodos se llaman en otros codigos suscribiendolos y haciendo que realizen una accion de un metodo especifico
    {
        if (CogerQueso != null)
            CogerQueso();
    }
    public static void Colisiongatico()
    {
        if (GatoCollision != null)
            GatoCollision();
    }
    public static void VoidAddforce()
    {
        if (Fuerza_Saltar != null)
            Fuerza_Saltar();
    }
    public static void VoidCollisionPared()
    {
        if (ParedCollision != null)
            ParedCollision();
    }
    public static void VoidExitPared()
    {
        if (ParedExit != null)
            ParedExit();
    }
    public static void VoidSumarScore()
    {
        if (SumarScore != null)
            SumarScore();
    }
    public static void VoidColliPlayer()
    {
        if (PlayerCollision != null)
            PlayerCollision();
    }
    public static void VoidColliObs()
    {
        if (ObsCollision != null)
            ObsCollision();
    }
    public static void VoidWinActive()
    {
        if (WinActive != null)
            WinActive();
    }
}
