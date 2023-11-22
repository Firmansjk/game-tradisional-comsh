using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaragaBallScript : MonoBehaviour
{
    public MaragaScore maragaScoreScript;
    public MaragaButtonController maragaButtonControllerScript1;
    public MaragaButtonController maragaButtonControllerScript2;
    public MaragaButtonController maragaButtonControllerScript3;
    public MaragaButtonController maragaButtonControllerScript4;
    public Rigidbody2D rb;

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
    //private void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //Karakter
    //    if (collision.gameObject == char1)
    //    {
    //        maragaScoreScript.IncrementPlayer1Score();
    //        transform.position = spawn1;
    //        rb.Sleep();
    //        rb.velocity = new Vector2(0,0);
    //        maragaButtonControllerScript1.canLaunchBall = true;
    //        maragaButtonControllerScript2.canLaunchBall = true;
    //        maragaButtonControllerScript3.canLaunchBall = true;
    //        maragaButtonControllerScript4.canLaunchBall = true;
    //        char1.GetComponent<Collider2D>().enabled = false;
    //        char2.GetComponent<Collider2D>().enabled = true;
    //        char3.GetComponent<Collider2D>().enabled = true;
    //        char4.GetComponent<Collider2D>().enabled = true;
    //    }
    //    if (collision.gameObject == char2)
    //    {
    //        maragaScoreScript.IncrementPlayer2Score();
    //        transform.position = spawn2;
    //        rb.Sleep();
    //        rb.velocity = new Vector2(0, 0);
    //        maragaButtonControllerScript1.canLaunchBall = true;
    //        maragaButtonControllerScript2.canLaunchBall = true;
    //        maragaButtonControllerScript3.canLaunchBall = true;
    //        maragaButtonControllerScript4.canLaunchBall = true;
    //        char1.GetComponent<Collider2D>().enabled = true;
    //        char2.GetComponent<Collider2D>().enabled = false;
    //        char3.GetComponent<Collider2D>().enabled = true;
    //        char4.GetComponent<Collider2D>().enabled = true;
    //    }
    //    if (collision.gameObject == char3)
    //    {
    //        maragaScoreScript.IncrementPlayer2Score();
    //        transform.position = spawn3;
    //        rb.Sleep();
    //        rb.velocity = new Vector2(0, 0);
    //        maragaButtonControllerScript1.canLaunchBall = true;
    //        maragaButtonControllerScript2.canLaunchBall = true;
    //        maragaButtonControllerScript3.canLaunchBall = true;
    //        maragaButtonControllerScript4.canLaunchBall = true;
    //        char1.GetComponent<Collider2D>().enabled = true;
    //        char2.GetComponent<Collider2D>().enabled = true;
    //        char3.GetComponent<Collider2D>().enabled = false;
    //        char4.GetComponent<Collider2D>().enabled = true;
    //    }
    //    if (collision.gameObject == char4)
    //    {
    //        maragaScoreScript.IncrementPlayer1Score();
    //        transform.position = spawn4;
    //        rb.Sleep();
    //        rb.velocity = new Vector2(0, 0);
    //        maragaButtonControllerScript1.canLaunchBall = true;
    //        maragaButtonControllerScript2.canLaunchBall = true;
    //        maragaButtonControllerScript3.canLaunchBall = true;
    //        maragaButtonControllerScript4.canLaunchBall = true;
    //        char1.GetComponent<Collider2D>().enabled = true;
    //        char2.GetComponent<Collider2D>().enabled = true;
    //        char3.GetComponent<Collider2D>().enabled = true;
    //        char4.GetComponent<Collider2D>().enabled = false;
    //    }
    //    //Pembatas
    //    if (collision.gameObject == pembatas1)
    //    {
    //        transform.position = spawn1;
    //        rb.Sleep();
    //        rb.velocity = new Vector2(0, 0);
    //        maragaButtonControllerScript1.canLaunchBall = true;
    //        maragaButtonControllerScript2.canLaunchBall = true;
    //        maragaButtonControllerScript3.canLaunchBall = true;
    //        maragaButtonControllerScript4.canLaunchBall = true;
    //        char1.GetComponent<Collider2D>().enabled = false;
    //        char2.GetComponent<Collider2D>().enabled = true;
    //        char3.GetComponent<Collider2D>().enabled = true;
    //        char4.GetComponent<Collider2D>().enabled = true;
    //    }
    //    if (collision.gameObject == pembatas2)
    //    {
    //        transform.position = spawn2;
    //        rb.Sleep();
    //        rb.velocity = new Vector2(0, 0);
    //        maragaButtonControllerScript1.canLaunchBall = true;
    //        maragaButtonControllerScript2.canLaunchBall = true;
    //        maragaButtonControllerScript3.canLaunchBall = true;
    //        maragaButtonControllerScript4.canLaunchBall = true;
    //        char1.GetComponent<Collider2D>().enabled = true;
    //        char2.GetComponent<Collider2D>().enabled = false;
    //        char3.GetComponent<Collider2D>().enabled = true;
    //        char4.GetComponent<Collider2D>().enabled = true;
    //    }
    //    if (collision.gameObject == pembatas3)
    //    {
    //        transform.position = spawn3;
    //        rb.Sleep();
    //        rb.velocity = new Vector2(0, 0);
    //        maragaButtonControllerScript1.canLaunchBall = true;
    //        maragaButtonControllerScript2.canLaunchBall = true;
    //        maragaButtonControllerScript3.canLaunchBall = true;
    //        maragaButtonControllerScript4.canLaunchBall = true;
    //        char1.GetComponent<Collider2D>().enabled = true;
    //        char2.GetComponent<Collider2D>().enabled = true;
    //        char3.GetComponent<Collider2D>().enabled = false;
    //        char4.GetComponent<Collider2D>().enabled = true;
    //    }
    //    if (collision.gameObject == pembatas4)
    //    {
    //        transform.position = spawn4;
    //        rb.Sleep();
    //        rb.velocity = new Vector2(0, 0);
    //        maragaButtonControllerScript1.canLaunchBall = true;
    //        maragaButtonControllerScript2.canLaunchBall = true;
    //        maragaButtonControllerScript3.canLaunchBall = true;
    //        maragaButtonControllerScript4.canLaunchBall = true;
    //        char1.GetComponent<Collider2D>().enabled = true;
    //        char2.GetComponent<Collider2D>().enabled = true;
    //        char3.GetComponent<Collider2D>().enabled = true;
    //        char4.GetComponent<Collider2D>().enabled = false;
    //    }
    //}
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Characters
        if (collision.gameObject == char1)
        {
            HandleCollision(char1, spawn1, spawn4, true, false, false, false);
        }
        else if (collision.gameObject == char2)
        {
            HandleCollision(char2, spawn2, spawn3, false, true, false, false);
        }
        else if (collision.gameObject == char3)
        {
            HandleCollision(char3, spawn3, spawn2, false, false, true, false);
        }
        else if (collision.gameObject == char4)
        {
            HandleCollision(char4, spawn4, spawn1, false, false, false, true);
        }
        // Pemabatas
        else if (collision.gameObject == pembatas1)
        {
            HandleCollision(pembatas1, spawn1, spawn4, true, false, false, false);
        }
        else if (collision.gameObject == pembatas2)
        {
            HandleCollision(pembatas2, spawn2, spawn3, false, true, false, false);
        }
        else if (collision.gameObject == pembatas3)
        {
            HandleCollision(pembatas3, spawn3, spawn2, false, false, true, false);
        }
        else if (collision.gameObject == pembatas4)
        {
            HandleCollision(pembatas4, spawn4, spawn1, false, false, false, true);
        }
    }

    private void HandleCollision(GameObject character, Vector3 spawnPoint, Vector3 invalidSpawnPoint, bool enableChar1, bool enableChar2, bool enableChar3, bool enableChar4)
    {
        if (transform.position == spawnPoint)
        {
            if (character == char1)
            {
                maragaScoreScript.IncrementPlayer1Score();
            }
            else if (character == char4)
            {
                maragaScoreScript.IncrementPlayer1Score();
            }
            else if (character == char2)
            {
                maragaScoreScript.IncrementPlayer2Score();
            }
            else if (character == char3)
            {
                maragaScoreScript.IncrementPlayer2Score();
            }

            transform.position = spawnPoint;
        }
        else if (transform.position == invalidSpawnPoint)
        {
            // Do not increment score when the ball is in an invalid spawn point
            transform.position = invalidSpawnPoint;
        }

        ResetBall();
        EnableColliders(enableChar1, enableChar2, enableChar3, enableChar4);
    }

    private void ResetBall()
    {
        rb.Sleep();
        rb.velocity = Vector2.zero;
        maragaButtonControllerScript1.canLaunchBall = true;
        maragaButtonControllerScript2.canLaunchBall = true;
        maragaButtonControllerScript3.canLaunchBall = true;
        maragaButtonControllerScript4.canLaunchBall = true;
    }

    private void EnableColliders(bool enableChar1, bool enableChar2, bool enableChar3, bool enableChar4)
    {
        char1.GetComponent<Collider2D>().enabled = enableChar1;
        char2.GetComponent<Collider2D>().enabled = enableChar2;
        char3.GetComponent<Collider2D>().enabled = enableChar3;
        char4.GetComponent<Collider2D>().enabled = enableChar4;
    }
}
