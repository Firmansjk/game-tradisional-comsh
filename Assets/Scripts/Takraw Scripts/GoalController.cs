using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public Text p1ScoreText;
    public Text p2ScoreText;
    public int p1Score = 0;
    public int p2Score = 0;
    public BallController ballControllerScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isRight)
            {
                //manager.AddRightScore(1);
                p1Score += 1;
                p1ScoreText.text = p1Score.ToString();
            }
            else
            {
                //manager.AddLeftScore(1);
                p2Score += 1;
                p2ScoreText.text = p2Score.ToString();
            }
            ballControllerScript.ResetBall();
        }
    }
}
