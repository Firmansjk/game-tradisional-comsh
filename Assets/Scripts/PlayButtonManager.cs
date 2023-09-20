using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonManager : MonoBehaviour
{
    public InputField playerOneNameInput;
    public InputField playerTwoNameInput;
    public GameObject playButton;
    public PlayerOneCharacterSelection playerOneData;
    public PlayerTwoCharacterSelection playerTwoData;

    private void Update()
    {
        // Check if both input fields are filled to enable the "Play" button.
        if (!string.IsNullOrEmpty(playerOneNameInput.text) && !string.IsNullOrEmpty(playerTwoNameInput.text))
        {
            playButton.SetActive(true);
        }
        else
        {
            playButton.SetActive(false);
        }
    }

    public void StartGamePreparation()
    {
        playerOneData.StartGamePreparation1();
        playerTwoData.StartGamePreparation2();

        // Load the game scene.
        SceneManager.LoadScene("LattoLattoScene", LoadSceneMode.Single);
    }
}
