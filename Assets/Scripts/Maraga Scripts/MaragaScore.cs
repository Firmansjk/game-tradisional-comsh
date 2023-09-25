using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaragaScore : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public Text player1ScoreText; // Reference to the UI Text element for Player 1's score
    public Text player2ScoreText; // Reference to the UI Text element for Player 2's score

    public void IncrementPlayer1Score()
    {
        player1Score++;
        UpdateUIScores();
    }

    public void IncrementPlayer2Score()
    {
        player2Score++;
        UpdateUIScores();
    }

    private void UpdateUIScores()
    {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = player2Score.ToString();
    }
}
