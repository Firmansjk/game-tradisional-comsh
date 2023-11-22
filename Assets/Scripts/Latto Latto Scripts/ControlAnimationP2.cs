using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlAnimationP2 : MonoBehaviour
{
    public Animator animP2;
    public Slider sliderP2;
    void Start()
    {
        animP2 = GetComponent<Animator>();
        animP2.speed = 0;
    }

    void Update()
    {
        float normalizedValue = sliderP2.normalizedValue;

        // Check if the slider value is at the maximum
        if (normalizedValue == 1.0f)
        {
            // If at maximum, set the normalizedValue to 0.999 to stay in the last frame
            normalizedValue = 0.999f;
        }
        animP2.Play("Lattolattokiri", -1, normalizedValue);
    }
}
