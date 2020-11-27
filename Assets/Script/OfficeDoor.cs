using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoor : MonoBehaviour
{
    public GameObject newState; 
    private bool isPointing;

    void Start()
    {
        isPointing = false;
        SetGoodStateOfActivation();
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
        DataBase.Instance.isOfficeDoorActivated = true;
        //replace the old picture by the new one
        newState.SetActive(true);
        this.gameObject.SetActive(false);
    }

    //This fonction return true if Player have the item to interact with this object (like the screwdriver for the vent)
    private bool CanPlayerInteract()
    {
        return DataBase.Instance.hasOfficeKey;        
    }

    public void SetGoodStateOfActivation()
    {
        gameObject.SetActive(!DataBase.Instance.isOfficeDoorActivated);
        newState.SetActive(DataBase.Instance.isOfficeDoorActivated);
    }
}
