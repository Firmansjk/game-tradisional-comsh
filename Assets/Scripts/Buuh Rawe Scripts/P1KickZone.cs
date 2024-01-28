using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1KickZone : MonoBehaviour
{
    public BuuhRaweBallController buuhRaweBallControllerScript;
    public GameObject kickButtonP1;
    public GameObject buuhRaweBall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        buuhRaweBallControllerScript.canKick = true;
        if (collision.gameObject.CompareTag("Ball"))
        {
            kickButtonP1.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        buuhRaweBallControllerScript.canKick = false;
        if (collision.gameObject.CompareTag("Ball"))
        {
            kickButtonP1.SetActive(false);
        }
    }
}
