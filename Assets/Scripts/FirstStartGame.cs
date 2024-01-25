using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStartGame : MonoBehaviour
{
    public StageController stageControllerScript;
    private void Awake()
    {
        stageControllerScript = GameObject.Find("StageController").GetComponent<StageController>();
    }
    public void FirstStart()
    {
        stageControllerScript.StartGameGo();
    }
}
