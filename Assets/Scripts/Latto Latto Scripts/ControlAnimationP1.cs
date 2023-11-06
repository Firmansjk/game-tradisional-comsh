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
        animP1.Play("Lattolattokanan", -1, sliderP1.normalizedValue);
    }
}
