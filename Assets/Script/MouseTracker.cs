using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));      
    }
}
