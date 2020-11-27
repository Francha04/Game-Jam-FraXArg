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
    void Start()
    {
        gameObject.SetActive(!isClicked);
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
        screwdriver.Instance.isClicked = true;
        gameObject.SetActive(false);
        UIManager.instance.ActivateUIItem(UIManager.instance.Screwdriver);
    }
}
