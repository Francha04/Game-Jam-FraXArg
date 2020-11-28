using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerManager : MonoBehaviour
{
    public float myTimer = 600;
    private bool timerIsActive = false;

    private static timerManager instance = null;
    public static timerManager Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (timerIsActive)
        {
            myTimer -= Time.deltaTime;

            if (myTimer <= 0)
            {
                myTimer = 0;
                timerIsActive = false;
                SceneManager.LoadScene("Lose Screen");
            }
        }

    }
    public void turnOnTimer() {
        myTimer = 600;
        timerIsActive = true; 
    }
}
