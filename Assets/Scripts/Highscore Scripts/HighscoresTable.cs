using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoresTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    //private List<HighScoreEntry> highscoreEntryList;
    private List<Transform> highscoreEntryTransformList;
    private void Awake()
    {
        entryContainer = transform.Find("HighscoreEntryContainer");
        entryTemplate = entryContainer.Find("HighscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false); //kasih sembunyi template

        //get value dari playerprefs temporal diawal
        // Get the character and score values from PlayerPrefs
        string playerOneCharacter = PlayerPrefs.GetString("PlayerOneSelectedCharacter");
        string playerTwoCharacter = PlayerPrefs.GetString("PlayerTwoSelectedCharacter");
        int playerOneScore = PlayerPrefs.GetInt("PlayerOneScore");
        int playerTwoScore = PlayerPrefs.GetInt("PlayerTwoScore");

        //if null
        if (playerOneScore != 0 && playerTwoScore != 0)
        {
            //Menambah data
            AddHighscoreEntry(playerOneCharacter, playerOneScore); //ini mau dikasih berdasarkan playerprefs temporal yang dibikin untuk P1 dan P2
            AddHighscoreEntry(playerTwoCharacter, playerTwoScore);
        }

        //ambil data dari json
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);


        //Sorting algorithm
        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    //swap
                    HighScoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;
                }
            }
        }

        //testing function create
        highscoreEntryTransformList = new List<Transform>();
        foreach (HighScoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }

        //saving pakai jsonutility
        /*Highscores highscores = new Highscores { highscoreEntryList = highscoreEntryList }; //semacam third-party dari bawah
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("highscoreTable"));*/
    }

    /*Function untuk membuat table highscore entry*/
    private void CreateHighscoreEntryTransform(HighScoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 45f;
        //posisi template
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        //ranking
        int rank = transformList.Count + 1;
        string rankString;
        switch (rank)
        {
            default:
                rankString = rank + "TH"; break;
            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }
        entryTransform.Find("Rank").GetComponent<Text>().text = rankString;

        //Naming
        string name = highscoreEntry.name;
        entryTransform.Find("Name").GetComponent<Text>().text = name;

        //Scoring
        int score = highscoreEntry.score;
        entryTransform.Find("Score").GetComponent<Text>().text = score.ToString();

        transformList.Add(entryTransform);
    }

    /*Function untuk menambah entry*/
    private void AddHighscoreEntry(string name, int score)
    {
        //Membuat HighScoreEntry
        HighScoreEntry highScoreEntry = new HighScoreEntry { name = name, score = score };

        //Load Save
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        //cek error null
        if (highscores == null)
        {
            highscores = new Highscores();
        }
        if (highscores.highscoreEntryList == null)
        {
            highscores.highscoreEntryList = new List<HighScoreEntry>();
        }

        //Add entry baru ke Highscores
        highscores.highscoreEntryList.Add(highScoreEntry);

        //Save Highscores terbaru/terupdate
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }

    /*class untuk keperluan convert json*/
    private class Highscores
    {
        public List<HighScoreEntry> highscoreEntryList;
    }

    /*class untuk satu per higscore entry*/
    [System.Serializable]
    private class HighScoreEntry
    {
        public string name;
        public int score;
    }
}
