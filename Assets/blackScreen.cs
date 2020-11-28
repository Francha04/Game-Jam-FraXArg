using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackScreen : MonoBehaviour
{
    void Start()
    {
        this.gameObject.SetActive(DataBase.Instance.isLightOff);
    }

}
