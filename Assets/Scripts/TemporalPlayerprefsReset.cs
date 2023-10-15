using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporalPlayerprefsReset : MonoBehaviour
{
    //Delete value playerprefs
    void Start()
    {
        PlayerPrefs.DeleteKey("PlayerOneScore");
        PlayerPrefs.DeleteKey("PlayerTwoScore");
        PlayerPrefs.Save();
    }

}
