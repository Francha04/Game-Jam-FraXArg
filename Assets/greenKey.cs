using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenKey : MonoBehaviour
{
    public bool isClicked = false;
    private bool isPointing = false;
    [SerializeField] private GameObject child;
    //singleton properties **
    private static greenKey instance = null;
    public static greenKey Instance
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
        greenKey.Instance.isClicked = true;
        UIManager.instance.ActivateUIItem(UIManager.instance.GreenKey);
        DataBase.Instance.hasGreenKey = true;
        gameObject.SetActive(false);
    }
}
