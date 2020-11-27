using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screwdriver : MonoBehaviour
{
    public bool isClicked = false;
    private bool isPointing = false;
    [SerializeField] private GameObject child;
    //singleton properties **
    private static screwdriver instance = null;
    public static screwdriver Instance
    {
        get { return instance; }
    }
    //**

    void Start()
    {
        gameObject.SetActive(!isClicked);
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
    public void OnMouseDown()
    {
        ClickReaction();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneInformation.current.ShallCharacterMove = false;
        isPointing = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        SceneInformation.current.ShallCharacterMove = true;
        isPointing = false;
    }

    private void ClickReaction()
    {
        Instance.isClicked = true;
        DataBase.Instance.hasScrewdriver = true;
        UIManager.instance.ActivateUIItem(UIManager.instance.Screwdriver);
        gameObject.SetActive(false);
    }
}
