using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public bool isRugMoved;


    //singleton properties **
    private static DataBase instance = null;
    public static DataBase Instance
    {
        get { return instance; }
    }
    //**

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



   // Update is called once per frame
    void Update()
    {
        
    }

    public void Initialise()
    {
        isRugMoved = false;
        PlayerPrefs.SetInt("startingSide", 0);
    }
}
