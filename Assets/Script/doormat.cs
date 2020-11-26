using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class doormat : MonoBehaviour
{
    public GameObject newState; //A picture of the doormat after the character bent it to look what is below.
    public GameObject key;

  

    public void OnMouseDown()
    {
        ClickReaction();
    }
    public void ClickReaction()
    {
        //replace the old picture by the new one
        newState.SetActive(true);
        // revelling the key
        key.SetActive(true);
        //revome the new picture
        this.gameObject.SetActive(false);
    }
}
