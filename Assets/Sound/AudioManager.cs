using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    private AudioSource audioSource;

    // Add a public variable to store the different audio clips (songs)
    public AudioClip songMainMenu;
    public AudioClip songInGame;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            audioSource = GetComponent<AudioSource>();
            SceneManager.sceneLoaded += OnSceneLoaded; // Subscribe to the scene loaded event
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // This method will be called whenever a new scene is loaded
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check the scene name and play the appropriate song
        if (scene.name == "MainMenuScene")
        {
            PlayNewSong(songMainMenu);
        }
        else
        {
            PlayNewSong(songInGame);
        }
    }

    // Play a new song based on the provided AudioClip
    private void PlayNewSong(AudioClip newSong)
    {
        audioSource.clip = newSong;
        audioSource.Play();
    }
}
