using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider sliderObject;
    public Slider sliderObject2;
    public Text score1;
    public Text score2;
    public int score = 0;
    public int scoree = 0;

    void Start()
    {
        //sliderObject.minValue = 0;
        //sliderObject.maxValue = 100;
        //sliderObject.wholeNumbers = true;
        //sliderObject.value = 50;

        //sliderObject2.minValue = 0;
        //sliderObject2.maxValue = 100;
        //sliderObject2.wholeNumbers = true;
        //sliderObject2.value = 50;
    }

    public void OnValueChange(float value)
    {
        //if (sliderObject.value == 100)
        //{
        //    score += 1;
        //    score1.text = score.ToString();
        //}

        //if (sliderObject2.value == 100)
        //{
        //    scoree += 1;
        //    score2.text = scoree.ToString();
        //}
    }
}
