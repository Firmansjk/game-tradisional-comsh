using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaragaBallScript : MonoBehaviour
{
    public MaragaScore maragaScoreScript;

    public GameObject char1;
    public GameObject char2;
    public GameObject char3;
    public GameObject char4;

    public Vector3 spawn1;
    public Vector3 spawn2;
    public Vector3 spawn3;
    public Vector3 spawn4;

    public GameObject pembatas1;
    public GameObject pembatas2;
    public GameObject pembatas3;
    public GameObject pembatas4;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == char1)
        {
            maragaScoreScript.IncrementPlayer1Score();
            transform.position = spawn1;
        }
        if (collision.gameObject == char2)
        {
            maragaScoreScript.IncrementPlayer2Score();
            transform.position = spawn2;
        }
        if (collision.gameObject == char3)
        {
            maragaScoreScript.IncrementPlayer2Score();
            transform.position = spawn3;
        }
        if (collision.gameObject == char4)
        {
            maragaScoreScript.IncrementPlayer1Score();
            transform.position = spawn4;
        }
        if (collision.gameObject == pembatas1)
        {
            transform.position = spawn1;
        }
        if (collision.gameObject == pembatas2)
        {
            transform.position = spawn2;
        }
        if (collision.gameObject == pembatas3)
        {
            transform.position = spawn3;
        }
        if (collision.gameObject == pembatas4)
        {
            transform.position = spawn4;
        }
    }
}
