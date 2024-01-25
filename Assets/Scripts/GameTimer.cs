using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{

    [SerializeField] GameObject timeText;
    [SerializeField] GameObject winnerCanvas;
    public float timeRemaining = 60f;
    public bool timeIsRunning = false;
    public Text timerText;
    public Text p1Score;
    public Text p2Score;

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTimeClock(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timeIsRunning = false;
                timeText.SetActive(false);
                winnerCanvas.SetActive(true);
                //Menambah score ke temporal
                AddingScoreToTemporalPrefs();
                Invoke("ToNextLevel", 5.0f);
            }
        }
    }

    public void DisplayTimeClock(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public float GetTimeRemaining()
    {
        return timeRemaining;
    }

    public void TimeMove()
    {
        timeIsRunning = true;
    }

    public void ToNextLevel()
    {
        //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        //SceneManager.LoadScene(nextSceneIndex);
        GameObject.Find("StageController").GetComponent<StageController>().NextGameGo();
    }

    public void AddingScoreToTemporalPrefs()
    {
        int additionalP1score = int.Parse(p1Score.text);
        int additionalP2score = int.Parse(p2Score.text);

        // Retrieve scores from PlayerPrefs in Scene 2
        int playerOneScore = PlayerPrefs.GetInt("PlayerOneScore");
        int playerTwoScore = PlayerPrefs.GetInt("PlayerTwoScore");

        // Add values to the scores
        playerOneScore += additionalP1score;
        playerTwoScore += additionalP2score;

        // Save the updated scores
        PlayerPrefs.SetInt("PlayerOneScore", playerOneScore);
        PlayerPrefs.SetInt("PlayerTwoScore", playerTwoScore);
        PlayerPrefs.Save();
    }
}
