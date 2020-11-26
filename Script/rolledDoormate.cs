using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolledDoormate : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(DataBase.Instance.isRugMoved);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
