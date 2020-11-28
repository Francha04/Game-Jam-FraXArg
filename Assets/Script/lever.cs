using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    public GameObject leverOn;
    public GameObject leverOff;
    public GameObject ship;
    public GameObject key;
    private bool isPointing;
    public int elevatorHeight;
    public GameObject soundM;
    // Start is called before the first frame update
    void Start()
    {
        isPointing = false;
        leverOn.SetActive(DataBase.Instance.isElevatorUp);
        leverOff.SetActive(!DataBase.Instance.isElevatorUp);
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

    private void ClickReaction()
    {
        DataBase.Instance.isElevatorUp = !DataBase.Instance.isElevatorUp;
        Vector3 newPos = new Vector3(ship.transform.position.x, ship.transform.position.y, ship.transform.position.z);
        if (DataBase.Instance.isElevatorUp) {
            newPos.y = newPos.y + elevatorHeight;
            key.SetActive(true);
        } else { newPos.y = newPos.y - elevatorHeight; }
        ship.transform.position = newPos;
        soundM.GetComponent<AudioSource>().Play();
        leverOn.SetActive(!leverOn.activeSelf);
        leverOff.SetActive(!leverOff.activeSelf);
        
    }
}
