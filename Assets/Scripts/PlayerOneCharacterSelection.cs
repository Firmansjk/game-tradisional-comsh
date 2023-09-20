using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerOneCharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;

    public InputField playerNameInput;
    public Text playerScoreText;

    private string playerSelectedCharacter;
    private int playerScore = 0;
    private string playerAvatar;

    private void Start()
    {
        // Initialize the character selection by setting the initial character.
        UpdateCharacterSelection();
    }

    private void UpdateCharacterSelection()
    {
        playerSelectedCharacter = characters[selectedCharacter].name;
        //playerNameInput.text = playerSelectedCharacter;
        playerScoreText.text = "Player One Score: " + playerScore;
    }

    public void NextChar()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
        UpdateCharacterSelection();
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
        UpdateCharacterSelection();
    }

    public void StartGamePreparation1()
    {
        // Save selected character data and avatar for Player One to PlayerPrefs.
        PlayerPrefs.SetString("PlayerOneSelectedCharacter", playerSelectedCharacter);
        PlayerPrefs.SetInt("PlayerOneScore", playerScore);
        PlayerPrefs.SetString("PlayerOneAvatar", playerAvatar);
        PlayerPrefs.Save();

        // Load the game scene.
        //SceneManager.LoadScene("LattoLattoScene");
    }
}
