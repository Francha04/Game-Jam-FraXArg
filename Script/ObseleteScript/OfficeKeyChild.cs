﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeKeyChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(!OfficeKey.Instance.isClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
