using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class doormat : MonoBehaviour
{

    private bool isClicked;
    public GameObject newState; //The picture of the Doormat after the character bent it to look what is below.
    private bool isPointing;
    public GameObject soundM;
    private static doormat instance = null;
    public static doormat Instance
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
        isPointing = false;
        gameObject.SetActive(!isClicked);
        newState.SetActive(isClicked);
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

    public void ClickReaction()
    {
        //Save the fact the player click on this object
        isClicked = true;
        //replace the old picture by the new one
        newState.SetActive(true);
        soundM.GetComponent<AudioSource>().Play();
        this.gameObject.SetActive(false);
    }

}
