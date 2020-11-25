using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class doormat : MonoBehaviour
{
    public GameObject newState; //A picture of the doormat after the character bent it to look what is below.
    public GameObject key;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData data)
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
