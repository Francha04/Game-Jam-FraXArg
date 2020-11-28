using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public timerManager timeManager;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DataBase.Instance.Initialise();
            SceneManager.LoadScene("GarageDoor");
            timeManager.turnOnTimer();
        }
    }
}
