using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversibleClickableItem : MonoBehaviour
{
    private bool isClicked;
    public GameObject newState; //The picture of the ReversibleClickableItem after the character bent it to look what is below.
    private bool isPointing;

    private static ReversibleClickableItem instance = null;
    public static ReversibleClickableItem Instance
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
        isPointing = false;
        gameObject.SetActive(!isClicked);
        newState.SetActive(isClicked);
    }

    // Update is called once per frame
    void Update()
    {

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
        this.gameObject.SetActive(false);
    }
}
