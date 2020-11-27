using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    //This script can be add to an empty object to help you to get coordinates of the of some point of the screen.


    // Update is called once per frame
    void Update()
    {
        Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition)); //Print the coordinates of the pointer in the console.     
    }
}
