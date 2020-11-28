using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrance : MonoBehaviour
{
    public string nextLevel; //The name of the scene this entrance leads

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if ((PlayerControl.current.IsImmobile()) && (DataBase.Instance.isOfficeDoorActivated)) //Test to avoid going in the new scene if the player is just passing by the trigger
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
