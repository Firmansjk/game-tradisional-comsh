using UnityEngine;
using UnityEngine.UI;

public class GameDataLoader : MonoBehaviour
{
    public Text playerOneNameText;
    public Text playerTwoNameText;
    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    private void Start()
    {
        // Retrieve the saved data from PlayerPrefs for Player One and Player Two.
        string playerOneSelectedCharacter = PlayerPrefs.GetString("PlayerOneSelectedCharacter");
        int playerOneScore = PlayerPrefs.GetInt("PlayerOneScore");
        string playerOneAvatar = PlayerPrefs.GetString("PlayerOneAvatar");

        string playerTwoSelectedCharacter = PlayerPrefs.GetString("PlayerTwoSelectedCharacter");
        int playerTwoScore = PlayerPrefs.GetInt("PlayerTwoScore");
        string playerTwoAvatar = PlayerPrefs.GetString("PlayerTwoAvatar");

        // Assign the retrieved data to the appropriate game objects or variables in your scene.
        playerOneNameText.text = playerOneSelectedCharacter;
        playerTwoNameText.text = playerTwoSelectedCharacter;
        //playerOneScoreText.text = playerOneScore.ToString();
        //playerTwoScoreText.text = playerTwoScore.ToString();

        // Log the retrieved data to the console to check if it's correct.
        //Debug.Log("Player One Score: " + playerOneScore);
        //Debug.Log("Player One Avatar: " + playerOneAvatar);
        //Debug.Log("Player One Name: " + playerOneSelectedCharacter);

        //Debug.Log("Player Two Score: " + playerTwoScore);
        //Debug.Log("Player Two Avatar: " + playerTwoAvatar);
        //Debug.Log("Player Two Name: " + playerTwoSelectedCharacter);
    }
}
