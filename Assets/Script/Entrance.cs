using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrance : MonoBehaviour
{
    public string nextLevel; //The name of the scene this entrance leads

    public void OnTriggerStay(Collider collision)
    {
        if (PlayerControl.current.IsImmobile()) //Test to avoid going in the new scene if the player is just passing by the trigger
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

}
