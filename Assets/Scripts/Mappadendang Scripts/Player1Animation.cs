using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Animation : MonoBehaviour
{
    private Animator animatorP1;

    private void Start()
    {
        animatorP1 = GetComponent<Animator>();
        animatorP1.speed = 1;
        animatorP1.Play("MappadendangKanan2New", 0, 0);
    }

    public void PlayingAnimation()
    {
        animatorP1.Play("MappadendangKanan2New", 0, 0);
    }
}
