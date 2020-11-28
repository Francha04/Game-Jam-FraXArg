using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plotScreen : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timerManager._Instance.turnOnTimer();
            SceneManager.LoadScene("GarageDoor");
        }
    }
}
