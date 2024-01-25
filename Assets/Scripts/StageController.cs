using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour
{
    private static GameObject instance; //implementasi dont destroy on load
    private List<string> activeScenes; //list untuk scene yang akan dimainkan
    private string[] sceneOrder = { "LattoLattoScene", "TakrawScene", "MaragaScene", "BuuhraweScene", "MappadendangScene" }; //list nama nama scene
    public Toggle toggleGame1;
    public Toggle toggleGame2;
    public Toggle toggleGame3;
    public Toggle toggleGame4;
    public Toggle toggleGame5;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        activeScenes = new List<string>();
        if (instance == null)
        {
            instance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //otomatis cari toggle
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Active Scenes:");

            foreach (string scene in activeScenes)
            {
                Debug.Log(scene);
            }
        }
    }

    public void FindToggleGameobject()
    {
        //otomatis cari toggle
        toggleGame1 = GameObject.Find("Lattolatto toggle").GetComponent<Toggle>();
        toggleGame2 = GameObject.Find("Takraw toggle").GetComponent<Toggle>();
        toggleGame3 = GameObject.Find("Maraga toggle").GetComponent<Toggle>();
        toggleGame4 = GameObject.Find("Buuh Rawe toggle").GetComponent<Toggle>();
        toggleGame5 = GameObject.Find("Mappadendang toggle").GetComponent<Toggle>();
    }

    public void StartGameGo()
    {
        //start game awal awal
        //yang aktif dikasih masuk ke list
        if (toggleGame1.isOn)
        {
            activeScenes.Add(sceneOrder[0]);
        }
        if (toggleGame2.isOn)
        {
            activeScenes.Add(sceneOrder[1]);
        }
        if (toggleGame3.isOn)
        {
            activeScenes.Add(sceneOrder[2]);
        }
        if (toggleGame4.isOn)
        {
            activeScenes.Add(sceneOrder[3]);
        }
        if (toggleGame5.isOn)
        {
            activeScenes.Add(sceneOrder[4]);
        }
    }

    public void FirstNextGameGo()
    {
        //pertama kali
        if (activeScenes.Count > 0)
        {
            SceneManager.LoadScene(activeScenes[0]);
        }
        else
        {
            SceneManager.LoadScene("MainMenuScene");
        }
    }
    public void NextGameGo()
    {
        //to the next game
        // Remove the completed scene from the list
        activeScenes.Remove(activeScenes[0]);

        // If there are more scenes in the list, load the next one
        if (activeScenes.Count > 0)
        {
            SceneManager.LoadScene(activeScenes[0]);
        }
        else
        {
            // No more scenes, return to the highscore
            SceneManager.LoadScene("AfterHighscoreScene");
        }
    }

}
