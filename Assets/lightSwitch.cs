using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    public GameObject newState; //The picture of the IrreversibleClickableItemTemplate after the character interact with.
    private bool isPointing;
    public GameObject darkScreen;
    public GameObject greenKey;
    public GameObject soundM;

    // Start is called before the first frame update
    void Start()
    {
        isPointing = false;
        SetGoodStateOfActivation();
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
        DataBase.Instance.isLightOff = !DataBase.Instance.isLightOff;
        //replace the old picture by the new one
        newState.SetActive(true);
        soundM.GetComponent<AudioSource>().Play();
        darkScreen.SetActive(DataBase.Instance.isLightOff);
        if (!DataBase.Instance.hasGreenKey) { greenKey.SetActive(DataBase.Instance.isLightOff); }
        this.gameObject.SetActive(false);
    }

    //This fonction return true if Player have the item to interact with this object (like the screwdriver for the vent)

    public void SetGoodStateOfActivation()
    {
        gameObject.SetActive(!DataBase.Instance.isLightOff);
        newState.SetActive(DataBase.Instance.isLightOff);
    }
}
