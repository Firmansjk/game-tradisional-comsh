using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoving : MonoBehaviour
{
    public void LoadLattoLatto()
    {
        SceneManager.LoadScene("LattoLattoScene");
    }
    public void LoadTakraw()
    {
        SceneManager.LoadScene("TakrawScene");
    }
    public void LoadBuuhRawe()
    {
        SceneManager.LoadScene("BuuhRaweScene");
    }
}
