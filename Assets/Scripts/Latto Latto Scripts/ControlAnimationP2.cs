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
        animP2.Play("Lattolattokiri", -1, sliderP2.normalizedValue);
    }
}
