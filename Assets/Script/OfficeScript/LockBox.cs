using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBox : MonoBehaviour
{

    private bool isPointed;
    // Start is called before the first frame update
    void Start()
    {
        isPointed = false;
    }

    public void OnMouseDown()
    {
        ClickReaction();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneInformation.current.ShallCharacterMove = false;
        isPointed = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        SceneInformation.current.ShallCharacterMove = true;
        isPointed = false;
    }

    private void ClickReaction()
    {
        Debug.Log("On me clique dessus");
        if ((DataBase.Instance.hasBlueKey) && (DataBase.Instance.hasGreenKey) && (DataBase.Instance.hasPurpleKey) && (DataBase.Instance.hasRedKey))
        {
            Debug.Log("Tu as gagné");
            SceneInformation.current.LoadNextScene("Win Screen");
        }
    }
}
