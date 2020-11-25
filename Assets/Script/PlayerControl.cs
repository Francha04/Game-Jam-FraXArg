using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl current;
    private Vector2 target;
    public float speed=5f;


    private void Awake()
    {
        current = this;
    }
    private void Start()
    {
        target = transform.position;
    }


    // Update is called once per frame
    void Update()
    {

        //getting the coordinate of the mouse
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Check if user is clicking and get the coordinates if he does.
        if (Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousePos.x, Mathf.Clamp(mousePos.y, SceneInformation.current.yMin, SceneInformation.current.yMax));
        }
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime*speed);
        //Check if character is quiting the scene
        if ((transform.position.x < SceneInformation.current.xMin) && (SceneInformation.current.LeftLevel != ""))
        {
            SceneManager.LoadScene(SceneInformation.current.LeftLevel);
        }
        if ((transform.position.x > SceneInformation.current.xMax) && (SceneInformation.current.RightLevel != ""))
        {
            SceneManager.LoadScene(SceneInformation.current.RightLevel);
        }
    }

    public bool IsImmobile()
    {
        return ((transform.position.x == target.x)&&(transform.position.y==target.y));
    }
}
