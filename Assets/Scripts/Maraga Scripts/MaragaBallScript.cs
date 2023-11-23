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

    public bool canScore14;
    public bool canScore23;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canScore14 = true;
        canScore23 = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Karakter
        if (collision.gameObject == char1)
        {
            if (canScore14)
            {
                maragaScoreScript.IncrementPlayer1Score();
            }
            transform.position = spawn1;
            rb.Sleep();
            rb.velocity = new Vector2(0, 0);
            maragaButtonControllerScript1.canLaunchBall = true;
            maragaButtonControllerScript2.canLaunchBall = true;
            maragaButtonControllerScript3.canLaunchBall = true;
            maragaButtonControllerScript4.canLaunchBall = true;
            char1.GetComponent<Collider2D>().enabled = false;
            char2.GetComponent<Collider2D>().enabled = true;
            char3.GetComponent<Collider2D>().enabled = true;
            char4.GetComponent<Collider2D>().enabled = true;
            canScore23 = true;
            canScore14 = false;
        }
        if (collision.gameObject == char2)
        {
            if (canScore23)
            {
                maragaScoreScript.IncrementPlayer2Score();
            }
            transform.position = spawn2;
            rb.Sleep();
            rb.velocity = new Vector2(0, 0);
            maragaButtonControllerScript1.canLaunchBall = true;
            maragaButtonControllerScript2.canLaunchBall = true;
            maragaButtonControllerScript3.canLaunchBall = true;
            maragaButtonControllerScript4.canLaunchBall = true;
            char1.GetComponent<Collider2D>().enabled = true;
            char2.GetComponent<Collider2D>().enabled = false;
            char3.GetComponent<Collider2D>().enabled = true;
            char4.GetComponent<Collider2D>().enabled = true;
            canScore23 = false;
            canScore14 = true;
        }
        if (collision.gameObject == char3)
        {
            if (canScore23)
            {
                maragaScoreScript.IncrementPlayer2Score();
            }
            transform.position = spawn3;
            rb.Sleep();
            rb.velocity = new Vector2(0, 0);
            maragaButtonControllerScript1.canLaunchBall = true;
            maragaButtonControllerScript2.canLaunchBall = true;
            maragaButtonControllerScript3.canLaunchBall = true;
            maragaButtonControllerScript4.canLaunchBall = true;
            char1.GetComponent<Collider2D>().enabled = true;
            char2.GetComponent<Collider2D>().enabled = true;
            char3.GetComponent<Collider2D>().enabled = false;
            char4.GetComponent<Collider2D>().enabled = true;
            canScore23 = false;
            canScore14 = true;
        }
        if (collision.gameObject == char4)
        {
            if (canScore14)
            {
                maragaScoreScript.IncrementPlayer1Score();
            }
            transform.position = spawn4;
            rb.Sleep();
            rb.velocity = new Vector2(0, 0);
            maragaButtonControllerScript1.canLaunchBall = true;
            maragaButtonControllerScript2.canLaunchBall = true;
            maragaButtonControllerScript3.canLaunchBall = true;
            maragaButtonControllerScript4.canLaunchBall = true;
            char1.GetComponent<Collider2D>().enabled = true;
            char2.GetComponent<Collider2D>().enabled = true;
            char3.GetComponent<Collider2D>().enabled = true;
            char4.GetComponent<Collider2D>().enabled = false;
            canScore23 = true;
            canScore14 = false;
        }
        //Pembatas
        if (collision.gameObject == pembatas1)
        {
            transform.position = spawn1;
            rb.Sleep();
            rb.velocity = new Vector2(0, 0);
            maragaButtonControllerScript1.canLaunchBall = true;
            maragaButtonControllerScript2.canLaunchBall = true;
            maragaButtonControllerScript3.canLaunchBall = true;
            maragaButtonControllerScript4.canLaunchBall = true;
            char1.GetComponent<Collider2D>().enabled = false;
            char2.GetComponent<Collider2D>().enabled = true;
            char3.GetComponent<Collider2D>().enabled = true;
            char4.GetComponent<Collider2D>().enabled = true;
            canScore23 = true;
            canScore14 = false;
        }
        if (collision.gameObject == pembatas2)
        {
            transform.position = spawn2;
            rb.Sleep();
            rb.velocity = new Vector2(0, 0);
            maragaButtonControllerScript1.canLaunchBall = true;
            maragaButtonControllerScript2.canLaunchBall = true;
            maragaButtonControllerScript3.canLaunchBall = true;
            maragaButtonControllerScript4.canLaunchBall = true;
            char1.GetComponent<Collider2D>().enabled = true;
            char2.GetComponent<Collider2D>().enabled = false;
            char3.GetComponent<Collider2D>().enabled = true;
            char4.GetComponent<Collider2D>().enabled = true;
            canScore23 = false;
            canScore14 = true;
        }
        if (collision.gameObject == pembatas3)
        {
            transform.position = spawn3;
            rb.Sleep();
            rb.velocity = new Vector2(0, 0);
            maragaButtonControllerScript1.canLaunchBall = true;
            maragaButtonControllerScript2.canLaunchBall = true;
            maragaButtonControllerScript3.canLaunchBall = true;
            maragaButtonControllerScript4.canLaunchBall = true;
            char1.GetComponent<Collider2D>().enabled = true;
            char2.GetComponent<Collider2D>().enabled = true;
            char3.GetComponent<Collider2D>().enabled = false;
            char4.GetComponent<Collider2D>().enabled = true;
            canScore23 = false;
            canScore14 = true;
        }
        if (collision.gameObject == pembatas4)
        {
            transform.position = spawn4;
            rb.Sleep();
            rb.velocity = new Vector2(0, 0);
            maragaButtonControllerScript1.canLaunchBall = true;
            maragaButtonControllerScript2.canLaunchBall = true;
            maragaButtonControllerScript3.canLaunchBall = true;
            maragaButtonControllerScript4.canLaunchBall = true;
            char1.GetComponent<Collider2D>().enabled = true;
            char2.GetComponent<Collider2D>().enabled = true;
            char3.GetComponent<Collider2D>().enabled = true;
            char4.GetComponent<Collider2D>().enabled = false;
            canScore23 = true;
            canScore14 = false;
        }
    }
}
