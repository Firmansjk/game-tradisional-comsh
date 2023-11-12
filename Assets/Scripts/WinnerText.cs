using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerText : MonoBehaviour
{
    //public Text winnerIs;
    public Text scoreP1;
    public Text scoreP2;

    public GameObject imageP1;
    public GameObject imageP2;
    public GameObject imageDraw;
    public void Start()
    {
        whosTheWinner();
    }

    public void whosTheWinner()
    {
        if (int.Parse(scoreP1.text) > int.Parse(scoreP2.text))
        {
            //via nama player itu sendiri
            //string playerOneSelectedCharacter = PlayerPrefs.GetString("PlayerOneSelectedCharacter");
            //winnerIs.text = playerOneSelectedCharacter + " Menang!";
            //via gambar custom
            imageP1.SetActive(true);
        }
        else if (int.Parse(scoreP1.text) < int.Parse(scoreP2.text))
        {
            //via nama player itu sendiri
            //string playerTwoSelectedCharacter = PlayerPrefs.GetString("PlayerTwoSelectedCharacter");
            //winnerIs.text = playerTwoSelectedCharacter + " Menang!";
            //via gambar custom
            imageP2.SetActive(true);
        }
        else
        {
            //winnerIs.text = "Draw!";
            imageDraw.SetActive(true);
        }
    }
}
