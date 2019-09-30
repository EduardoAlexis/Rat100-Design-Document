using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidRedondo : MonoBehaviour
{
    public Slider SliderRedondo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SliderRedondo.value += Time.deltaTime *5; 
        if (SliderRedondo.value <= 0)
        {
            RatController.Speed = 3.2f;
        }
        if (SliderRedondo.value >= 50)
        {
            RatController.Speed = 2.8f;
        }
    }
}
