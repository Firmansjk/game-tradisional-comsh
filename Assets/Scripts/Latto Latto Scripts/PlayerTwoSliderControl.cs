using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoSliderControl : MonoBehaviour
{
    public Slider sliderObject;
    public Text scoreText;
    public int score = 0;

    void Start()
    {
        sliderObject.minValue = 0;
        sliderObject.maxValue = 100;
        sliderObject.wholeNumbers = true;
        sliderObject.value = 50;
    }

    public void OnValueChange(float value)
    {
        if (sliderObject.value == 100)
        {
            score += 1;
            scoreText.text = score.ToString();
        }
    }
}
