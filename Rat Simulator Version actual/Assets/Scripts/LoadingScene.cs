using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadingScene : MonoBehaviour
{
    public GameObject loadingPanel;
    public Slider slider;
    public TextMeshProUGUI progressTx;

    public void startChange() {  // Cambio de escenas para cada nivel
        StartCoroutine(LoadAsinc(1));
    }
    public void startChange2() {
        StartCoroutine(LoadAsinc(2));
    }
    public void startChange3() {
        StartCoroutine(LoadAsinc(3));
    }
    public void startChange4()
    {
        StartCoroutine(LoadAsinc(4));
    }

    IEnumerator LoadAsinc(int sIndex) { // Pantalla de carga , con progreso
        loadingPanel.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        AsyncOperation asyncOP = SceneManager.LoadSceneAsync(sIndex);

        while (!asyncOP.isDone) {
            float progress = Mathf.Clamp01(asyncOP.progress / 0.9f);
            slider.value = progress;
            progressTx.text = (progress * 100f).ToString("00") + "%";
            yield return null;
        }
    }

}
