using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{

    [SerializeField] GameObject timeText;
    [SerializeField] GameObject goalText;
    public float timeRemaining = 60f;
    public bool timeIsRunning = false;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timeIsRunning = true;
    }

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
                goalText.SetActive(true);
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


}
