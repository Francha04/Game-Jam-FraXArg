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

    public static UIManager instance;
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
            OfficeKey.SetActive(DataBase.Instance.hasOfficeKey);
            PurpleKey.SetActive(DataBase.Instance.hasPurpleKey);
            BlueKey.SetActive(DataBase.Instance.hasBlueKey);
            GreenKey.SetActive(DataBase.Instance.hasGreenKey);
            RedKey.SetActive(DataBase.Instance.hasRedKey);
            Screwdriver.SetActive(DataBase.Instance.hasScrewdriver);
    }

    public void ActivateUIItem(GameObject x)
    {
        x.SetActive(!x.activeSelf);
    }
}