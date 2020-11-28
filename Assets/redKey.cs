using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redKey : MonoBehaviour
{
    public bool isClicked = false;
    private bool isPointing = false;
    [SerializeField] private GameObject child;
    //singleton properties **
    private static redKey instance = null;
    public GameObject soundM;
    public static redKey Instance
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
        redKey.Instance.isClicked = true;
        UIManager.instance.ActivateUIItem(UIManager.instance.RedKey);
        soundM.GetComponent<AudioSource>().Play();
        DataBase.Instance.hasRedKey = true;
        gameObject.SetActive(false);
    }
}
