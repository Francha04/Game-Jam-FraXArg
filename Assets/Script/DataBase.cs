using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public bool isRugMoved;
    public bool hasOfficeKey;
    public bool hasPurpleKey;
    public bool hasBlueKey;
    public bool hasGreenKey; 
    public bool hasRedKey;
    public bool hasScrewdriver;
    public bool isDoormatActivated;
    public bool isOfficeDoorActivated;
    public bool isVentOpen;
    public bool isElevatorUp;
    public bool isLightOff;
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


    public void Initialise()
    {
        isRugMoved = false;
        hasOfficeKey = false;
        hasGreenKey = false;
        hasBlueKey = false;
        hasPurpleKey = false;
        hasRedKey = false;
        hasScrewdriver=false;
        isVentOpen = false;
        isElevatorUp = false;
        isLightOff = false;
        PlayerPrefs.SetInt("startingSide", 0);
    }
}
