using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeKey : MonoBehaviour
{
    private void OnMouseDown()
    {
        placeInInventory();
        this.gameObject.SetActive(false);
    }

    public void placeInInventory() 
    {
    }

}
