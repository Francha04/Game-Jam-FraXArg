﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DataBase.Instance.Initialise();       
            SceneManager.LoadScene("Plot scene");
        }
    }
}
