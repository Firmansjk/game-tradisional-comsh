using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{

    [SerializeField] GameObject timeText;
    [SerializeField] GameObject winnerText;
    public float timeRemaining = 60f;
    public bool timeIsRunning = false;
    public Text timerText;

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
                winnerText.SetActive(true);
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
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
