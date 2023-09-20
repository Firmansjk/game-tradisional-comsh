using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;

    public InputField playerOneNameInput;
    public InputField playerTwoNameInput;
    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    private string playerOneSelectedCharacter;
    private string playerTwoSelectedCharacter;
    private int playerOneScore = 0;
    private int playerTwoScore = 0;
    private string playerOneAvatar;
    private string playerTwoAvatar;

    private void Start()
    {
        // Initialize the character selection by setting the initial character.
        UpdateCharacterSelectionForPlayerOne();
        UpdateCharacterSelectionForPlayerTwo();
    }

    private void UpdateCharacterSelectionForPlayerOne()
    {
        playerOneSelectedCharacter = characters[selectedCharacter].name;
        playerOneNameInput.text = playerOneSelectedCharacter;
        playerOneScoreText.text = "Player One Score: " + playerOneScore;
    }

    private void UpdateCharacterSelectionForPlayerTwo()
    {
        playerTwoSelectedCharacter = characters[selectedCharacter].name;
        playerTwoNameInput.text = playerTwoSelectedCharacter;
        playerTwoScoreText.text = "Player Two Score: " + playerTwoScore;
    }

    public void NextChar()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
        UpdateCharacterSelectionForPlayerOne();
        UpdateCharacterSelectionForPlayerTwo();
    }

    public void PrevChar()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
        UpdateCharacterSelectionForPlayerOne();
        UpdateCharacterSelectionForPlayerTwo();
    }
    //public void NextChar()
    //{
    //    characters[selectedCharacter].SetActive(false);
    //    selectedCharacter = (selectedCharacter + 1) % characters.Length;
    //    characters[selectedCharacter].SetActive(true);
    //}

    //public void PrevChar()
    //{
    //    characters[selectedCharacter].SetActive(false);
    //    selectedCharacter--;
    //    if (selectedCharacter < 0)
    //    {
    //        selectedCharacter += characters.Length;
    //    }
    //    characters[selectedCharacter].SetActive(true);
    //}


    public void StartGamePreparation()
    {
        // Save selected character data and avatar for both players to PlayerPrefs.
        PlayerPrefs.SetString("PlayerOneSelectedCharacter", playerOneSelectedCharacter);
        PlayerPrefs.SetString("PlayerTwoSelectedCharacter", playerTwoSelectedCharacter);
        PlayerPrefs.SetInt("PlayerOneScore", playerOneScore);
        PlayerPrefs.SetInt("PlayerTwoScore", playerTwoScore);
        PlayerPrefs.SetString("PlayerOneAvatar", playerOneAvatar);
        PlayerPrefs.SetString("PlayerTwoAvatar", playerTwoAvatar);
        PlayerPrefs.Save();

        // Load the game scene.
        SceneManager.LoadScene("LattoLattoScene");
    }
}
