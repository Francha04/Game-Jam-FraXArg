using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public bool hasOfficeKey;
    public bool hasPurpleKey;
    public bool hasBlueKey;
    public bool hasGreenKey; 
    public bool hasRedKey;
    public bool hasScrewdriver;
    public bool isDoormatActivated;
    public bool isOfficeDoorActivated;
    public bool isVentOpen;
    public bool isIrreversibleClickableItemTemplateActivated;
    public bool isReversibleClickableItemTemplateActivated;


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
        hasOfficeKey = false;
        hasGreenKey = false;
        hasBlueKey = false;
        hasPurpleKey = false;
        hasRedKey = false;
        hasScrewdriver=false;
        isVentOpen = false;
        PlayerPrefs.SetInt("startingSide", 0);
    }
}
