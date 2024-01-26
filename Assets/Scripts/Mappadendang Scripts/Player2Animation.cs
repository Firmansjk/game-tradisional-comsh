using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Animation : MonoBehaviour
{
    private Animator animatorP2;

    private void Start()
    {
        animatorP2 = GetComponent<Animator>();
        animatorP2.speed = 1;
        animatorP2.Play("MappadendangKiri", 0, 0);
    }

    public void PlayingAnimation()
    {
        animatorP2.Play("MappadendangKiri", 0, 0);
    }
}
