using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrance : MonoBehaviour
{
    public string nextLevel;

    public void OnTriggerStay(Collider collision)
    {
        Debug.Log("Le joueur est devant la porte");
        if (PlayerControl.current.IsImmobile())
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

}
