using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItemTemplate : MonoBehaviour
{/*
    public bool isClicked = false;
    private bool isPointing = false;
    [SerializeField] private GameObject child;
    //singleton properties **
    private static PickableItemTemplate instance = null;
    public static PickableItemTemplate Instance
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
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(!isClicked);
    }

    // Update is called once per frame
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
        PickableItemTemplate.Instance.isClicked = true;
        gameObject.SetActive(false);
        UIManager.instance.ActivateUIItem(UIManager.instance.PickableItemTemplate);
    DataBase.Instance.hasPickableItemTemplate = true;
    }*/
}
