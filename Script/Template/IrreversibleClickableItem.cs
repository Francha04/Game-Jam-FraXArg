using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrreversibleClickableItem : MonoBehaviour
{
    private bool isClicked;
    public GameObject newState; //The picture of the IrreversibleClickableItem after the character interact with.
    private bool isPointing;

    private static IrreversibleClickableItem instance = null;
    public static IrreversibleClickableItem Instance
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
        if (CanPlayerInteract()) ClickReaction();
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

    //This fonction return true if Player have the item to interact with this object (like the screwdriver for the vent)
    private bool CanPlayerInteract()
    {
        throw new System.NotImplementedException();
    }
}
