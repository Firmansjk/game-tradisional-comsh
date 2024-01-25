using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1ButtonController : MonoBehaviour
{
    public Text scoreTextP1;
    public int scoreP1;
    public Player1Animation player1AnimationScript;
    
    public void AddScoreP1()
    {
        scoreP1++;
        scoreTextP1.text = scoreP1.ToString();
        if (player1AnimationScript != null)
        {
            player1AnimationScript.SetAnimationToFrame(1f);
        }
        else
        {
            Debug.LogError("Player1Animation script reference is not assigned!");
        }
    }
}
