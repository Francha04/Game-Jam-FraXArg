using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject OfficeKey;
    public GameObject PurpleKey;
    public GameObject BlueKey;
    public GameObject GreenKey;
    public GameObject RedKey;
    public GameObject Screwdriver;

    public UIManager instance;
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
        OfficeKey.SetActive(false);
        PurpleKey.SetActive(false);
        BlueKey.SetActive(false);
        GreenKey.SetActive(false);
        RedKey.SetActive(false);
        Screwdriver.SetActive(false);
    }
    void ActivateUIItem(GameObject x) 
    {
        x.SetActive(!x.activeSelf);
    }
}

