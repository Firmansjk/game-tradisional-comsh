using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Beras : MonoBehaviour
{
    private Animator animatorP1Beras;

    private void Start()
    {
        animatorP1Beras = GetComponent<Animator>();
        animatorP1Beras.speed = 1;
        animatorP1Beras.Play("BerasKanan", 0, 0);
    }
}
