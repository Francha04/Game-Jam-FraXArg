using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInformation : MonoBehaviour
{
    // This class contains usefull information about the scene
    public static SceneInformation current; //We use a singleton
    public float xMin=-4.8f; //Limit of the screen on x axis. If player exceed that point, he go to the next scene.
    public float xMax=4.8f;
    public float yMin=-5f;  //Limit of the walkable area, to avoid the player can climb the walls
    public float yMax=-0.5f; 
    public string LeftLevel; //Name of the scene the player can reach by the left side.
    public string RightLevel; //Name of the scene the player can reach by the right side.

    // Start is called before the first frame update
    void Awake()
    {
        current = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
