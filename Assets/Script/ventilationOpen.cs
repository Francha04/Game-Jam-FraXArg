using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventilationOpen : MonoBehaviour
{
    public GameObject newState; //The picture of the IrreversibleClickableItemTemplate after the character interact with.
    private bool isPointing;
    [SerializeField]private GameObject key;

    void Start()
    {
        isPointing = false;
        SetGoodStateOfActivation();
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
        DataBase.Instance.isVentOpen = true;
        //replace the old picture by the new one
        newState.SetActive(true);
        key.SetActive(true);
        this.gameObject.SetActive(false);
    }

    private bool CanPlayerInteract()
    {
        return DataBase.Instance.hasScrewdriver;
    }

    public void SetGoodStateOfActivation()
    {
        gameObject.SetActive(!DataBase.Instance.isVentOpen);
        newState.SetActive(DataBase.Instance.isVentOpen);
        key.SetActive(false);
    }
}
