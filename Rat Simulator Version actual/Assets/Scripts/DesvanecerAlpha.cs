using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesvanecerAlpha : MonoBehaviour
{
    public Image myPanel;
    float fadeTime = 0.5f;
    Color colorToFadeTo;
    public GameObject Inagen;
    float alpha;

    public void ComenzarDesvanecido()
    {
        StartCoroutine("FadeInColor");
        Inagen.SetActive(true);
    }
    IEnumerator FadeOutColor() // Desvanecido de alpha
    {
        print("ghdsf");
        alpha = 0;
        colorToFadeTo = new Color(1f, 1f, 1f, alpha);
        myPanel.CrossFadeColor(colorToFadeTo, fadeTime, true, true);
        yield return new WaitForSeconds(0.5f);
        Inagen.SetActive(false);
        //yield return null;
    }

    IEnumerator FadeInColor() // Aumento progresivo de alpha
    {
        //alpha = 0;
        //myPanel.enabled = true;
        alpha = 1;
        colorToFadeTo = new Color(1f, 1f, 1f, alpha);
        myPanel.CrossFadeColor(colorToFadeTo, fadeTime, false, true);
        yield return new WaitForSeconds(1f);
        StartCoroutine("FadeOutColor");


    }
}
