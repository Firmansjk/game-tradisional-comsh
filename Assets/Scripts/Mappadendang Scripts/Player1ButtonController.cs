using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1ButtonController : MonoBehaviour
{
    public Text scoreTextP1;
    public int scoreP1;
    public Player1Animation player1AnimationScript;
    public GameObject berasKanan;
    
    public void AddScoreP1()
    {
        scoreP1++;
        scoreTextP1.text = scoreP1.ToString();
        player1AnimationScript.PlayingAnimation();
        berasKanan.SetActive(true);
        Invoke("DeactivateVBeras", 0.6f);
    }
    public void MinusScoreP1() //mengurangi score
    {
        scoreP1--;
        scoreTextP1.text = scoreP1.ToString();
        player1AnimationScript.PlayingAnimation();
        berasKanan.SetActive(true);
        Invoke("DeactivateVBeras", 0.6f);
    }

    public void DeactivateVBeras()
    {
        berasKanan.SetActive(false);
    }
}
