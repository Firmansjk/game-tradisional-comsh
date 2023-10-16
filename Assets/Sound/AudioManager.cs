using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    // This function will be called before the Start function
    private void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If no instance exists, make this the instance and don't destroy it on scene load
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // If an instance already exists, destroy this object to prevent duplication
            Destroy(this.gameObject);
        }
    }
}
