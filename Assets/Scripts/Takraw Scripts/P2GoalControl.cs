using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2GoalControl : MonoBehaviour
{
    public Collider2D ball;
    public Text p2ScoreText;
    public int p2Score = 0;
    public BallController ballControllerScript;
    public P1PaddleController p1PaddleControllerScript;
    public P2PaddleController p2PaddleControllerScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            p2Score += 1;
            p2ScoreText.text = p2Score.ToString();
            //p1PaddleControllerScript.ResetPaddle();
            //p2PaddleControllerScript.ResetPaddle();
            //ballControllerScript.ResetBall();
        }
    }
}
