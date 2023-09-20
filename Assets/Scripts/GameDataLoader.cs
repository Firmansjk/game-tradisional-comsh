using UnityEngine;
using UnityEngine.UI;

public class GameDataLoader : MonoBehaviour
{
    public Text playerOneNameText;
    public Text playerTwoNameText;
    public Text playerOneScoreText;
    public Text playerTwoScoreText;
    public Image playerOneAvatarImage;
    public Image playerTwoAvatarImage;

    private void Start()
    {
        // Retrieve the saved data from PlayerPrefs for Player One and Player Two.
        string playerOneSelectedCharacter = PlayerPrefs.GetString("PlayerOneSelectedCharacter");
        int playerOneScore = PlayerPrefs.GetInt("PlayerOneScore");
        string playerOneAvatar = PlayerPrefs.GetString("PlayerOneAvatar");
        string playerOneName = PlayerPrefs.GetString("PlayerOneName");

        string playerTwoSelectedCharacter = PlayerPrefs.GetString("PlayerTwoSelectedCharacter");
        int playerTwoScore = PlayerPrefs.GetInt("PlayerTwoScore");
        string playerTwoAvatar = PlayerPrefs.GetString("PlayerTwoAvatar");
        string playerTwoName = PlayerPrefs.GetString("PlayerTwoName");

        // Assign the retrieved data to the appropriate game objects or variables in your scene.
        playerOneNameText.text = playerOneName;
        playerTwoNameText.text = playerTwoName;
        playerOneScoreText.text = playerOneScore.ToString();
        playerTwoScoreText.text = playerTwoScore.ToString();

        // Log the retrieved data to the console to check if it's correct.
        Debug.Log("Player One Character: " + playerOneSelectedCharacter);
        Debug.Log("Player One Score: " + playerOneScore);
        Debug.Log("Player One Avatar: " + playerOneAvatar);
        Debug.Log("Player One Name: " + playerOneName);

        Debug.Log("Player Two Character: " + playerTwoSelectedCharacter);
        Debug.Log("Player Two Score: " + playerTwoScore);
        Debug.Log("Player Two Avatar: " + playerTwoAvatar);
        Debug.Log("Player Two Name: " + playerTwoName);
    }
}
