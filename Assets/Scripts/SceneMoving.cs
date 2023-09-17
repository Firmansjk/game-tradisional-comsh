using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoving : MonoBehaviour
{
    public void LoadPreparationScene()
    {
        SceneManager.LoadScene("PreparationScene", LoadSceneMode.Single);
    }

    public void GoToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single);
    }

    public void LoadHighscoreScene()
    {
        SceneManager.LoadScene("AfterHighscoreScene", LoadSceneMode.Single);
    }
}
