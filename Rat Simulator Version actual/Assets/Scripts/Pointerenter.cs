using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Pointerenter : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool ispressed = false;
	
    public void OnPointerDown(PointerEventData eventData) // Esto se usa para saber si los botones estan presionados y hacer algo con ello , como activar una animacion
    {
        ispressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
