using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1GoalControl : MonoBehaviour
{
    public Collider2D ball;
    public Text p1ScoreText;
    public int p1Score = 0;
    public BallController ballControllerScript;
    public P1PaddleController p1PaddleControllerScript;
    public P2PaddleController p2PaddleControllerScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            p1Score += 1;
            p1ScoreText.text = p1Score.ToString();
            //p1PaddleControllerScript.ResetPaddle();
            //p2PaddleControllerScript.ResetPaddle();
            //ballControllerScript.ResetBall();
        }
    }


}
