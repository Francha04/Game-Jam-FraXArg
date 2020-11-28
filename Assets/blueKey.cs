using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blueKey : MonoBehaviour
{
    public bool isClicked = false;
    private bool isPointing = false;
    [SerializeField] private GameObject child;
    public GameObject soundM;
    //singleton properties **
    private static blueKey instance = null;
    public static blueKey Instance
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
    }
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Ship") { gameObject.SetActive(!isClicked); }
        else { this.gameObject.SetActive(false);  };
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
        blueKey.Instance.isClicked = true;
        UIManager.instance.ActivateUIItem(UIManager.instance.BlueKey);
        DataBase.Instance.hasBlueKey = true;
        soundM.GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
}
