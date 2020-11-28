using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverReseter : MonoBehaviour
{
    public GameObject leverOn;
    public GameObject leverOff;

    private void Start()
    {
        leverOn.SetActive(false);
        leverOff.SetActive(true);
        DataBase.Instance.isElevatorUp = false;
        Debug.Log('H');
    }
}
