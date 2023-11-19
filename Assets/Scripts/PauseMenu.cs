using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public void FreezeTime()
    {
        Time.timeScale = 0;
    }
    public void RunTime()
    {
        Time.timeScale = 1;
    }
}
