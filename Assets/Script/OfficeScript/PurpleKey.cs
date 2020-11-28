using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleKey : MonoBehaviour
{
    public bool isClicked = false;
    private bool isPointing = false;
    [SerializeField] private GameObject child;
    //singleton properties **
    private static PurpleKey instance = null;
    public static PurpleKey Instance
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
        PurpleKey.Instance.isClicked = true;
        UIManager.instance.ActivateUIItem(UIManager.instance.PurpleKey);
        DataBase.Instance.hasPurpleKey = true;
        gameObject.SetActive(false);
    }
}
