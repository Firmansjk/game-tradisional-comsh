using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerText : MonoBehaviour
{
    public Text winnerIs;
    public Text scoreP1;
    public Text scoreP2;
    public void Start()
    {
        whosTheWinner();
    }

    public void whosTheWinner()
    {
        if (int.Parse(scoreP1.text) > int.Parse(scoreP2.text))
        {
            string playerOneSelectedCharacter = PlayerPrefs.GetString("PlayerOneSelectedCharacter");
            winnerIs.text = playerOneSelectedCharacter + " Menang!";
        }
        else if (int.Parse(scoreP1.text) < int.Parse(scoreP2.text))
        {
            string playerTwoSelectedCharacter = PlayerPrefs.GetString("PlayerTwoSelectedCharacter");
            winnerIs.text = playerTwoSelectedCharacter + " Menang!";
        }
        else
        {
            winnerIs.text = "Draw!";
        }
    }
}
