using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlAnimationP1 : MonoBehaviour
{
    public Animator animP1;
    public Slider sliderP1;
    void Start()
    {
        animP1 = GetComponent<Animator>();
        animP1.speed = 0;
    }

    void Update()
    {
        float normalizedValue = sliderP1.normalizedValue;

        // Check if the slider value is at the maximum
        if (normalizedValue == 1.0f)
        {
            // If at maximum, set the normalizedValue to 0.999 to stay in the last frame
            normalizedValue = 0.999f;
        }
        animP1.Play("Lattolattokanannew", -1, normalizedValue);
    }
}
