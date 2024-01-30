using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Beras : MonoBehaviour
{
    private Animator animatorP2Beras;

    private void Start()
    {
        animatorP2Beras = GetComponent<Animator>();
        animatorP2Beras.speed = 1;
        animatorP2Beras.Play("BerasKanan", 0, 0);
    }
}
