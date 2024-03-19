using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player2ButtonController : MonoBehaviour
{
    public Text scoreTextP2;
    public int scoreP2;
    public Player2Animation player2AnimationScript;
    public GameObject berasKiri;

    public void AddScoreP2()
    {
        scoreP2++;
        scoreTextP2.text = scoreP2.ToString();
        player2AnimationScript.PlayingAnimation();
        berasKiri.SetActive(true);
        Invoke("DeactivateVBeras", 0.6f);
    }
    public void MinusScoreP2()
    {
        scoreP2--;
        scoreTextP2.text = scoreP2.ToString();
        player2AnimationScript.PlayingAnimation();
        berasKiri.SetActive(true);
        Invoke("DeactivateVBeras", 0.6f);
    }

    public void DeactivateVBeras()
    {
        berasKiri.SetActive(false);
    }
}
