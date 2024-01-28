using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2KickZone : MonoBehaviour
{
    public BuuhRaweBallController buuhRaweBallControllerScript;
    public GameObject kickButtonP2;
    public GameObject buuhRaweBall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        buuhRaweBallControllerScript.canKick = true;
        if (collision.gameObject.CompareTag("Ball"))
        {
            kickButtonP2.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        buuhRaweBallControllerScript.canKick = false;
        if (collision.gameObject.CompareTag("Ball"))
        {
            kickButtonP2.SetActive(false);
        }
    }
}
