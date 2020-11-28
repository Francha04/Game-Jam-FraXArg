using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicReproduction : MonoBehaviour
{
    //singleton properties **
    private static musicReproduction instance = null;
    public static musicReproduction Instance
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

}
