using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public GameObject goalP1;
    public GameObject goalP2;
    public GameObject batasAtas;
    public GameObject batasBawah;
    public GameObject batasKiri;
    public GameObject batasKanan;
    public GameObject paddle1;
    public GameObject paddle2;

    public Vector3 afterGoalP1;
    public Vector3 afterGoalP2;
    public Vector3 afterGoalPaddle1;
    public Vector3 afterGoalPaddle2;

    public int scoreP1 = 0;
    public int scoreP2 = 0;
    public Text scoreTextP1;
    public Text scoreTextP2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == goalP1)
        {
            scoreP2++;
            this.gameObject.transform.position = afterGoalP1;
            scoreTextP2.text = scoreP2.ToString();
            paddle1.transform.position = afterGoalPaddle1;
            paddle2.transform.position = afterGoalPaddle2;
        }
        if (collision.gameObject == goalP2)
        {
            scoreP1++;
            this.gameObject.transform.position = afterGoalP2;
            scoreTextP1.text = scoreP1.ToString();
            paddle1.transform.position = afterGoalPaddle1;
            paddle2.transform.position = afterGoalPaddle2;
        }
    }
}
