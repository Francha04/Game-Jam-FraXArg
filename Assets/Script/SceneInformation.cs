using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInformation : MonoBehaviour
{
    public static SceneInformation current; //We use a singleton
    public float xMin=-4.8f;
    public float xMax=4.8f;
    public float yMin=-5f;
    public float yMax=-0.5f;
    public string LeftLevel;
    public string RightLevel;

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
