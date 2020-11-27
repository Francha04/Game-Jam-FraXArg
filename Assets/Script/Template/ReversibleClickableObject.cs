using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversibleClickableObject : MonoBehaviour
{

    private bool isPointing;
    // Start is called before the first frame update
    void Start()
    {
        isPointing = false;
    }

    private void OnMouseDown()
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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ClickReaction()
    {
        gameObject.GetComponentInParent<ReversibleClikableObjectParent>().Toggle();
    }
}
