using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPicture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerControl.current.transform.position;
    }
}
