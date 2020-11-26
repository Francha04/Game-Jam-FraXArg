using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl current; //We use a singleton
    private Vector2 target; //Coordinate of where the player want to go
    public float speed=5f; //speed of the player character.


    private void Awake()
    {
        current = this;
    }
    private void Start()
    {
        // Initialising the player position
          int startingSize = PlayerPrefs.GetInt("startingSide"); //StartingSize negative means player come from the left, positive means it come from the right.
        float x;
        if (startingSize < 0) x = -4.5f;
        else if (startingSize > 0) x = 4.5f;
        else x = 0f;
        Vector3 startPostion = new Vector3(x, transform.position.y);
        target = transform.position; //To avoid the character move before the player click somewhere.

    }


    // Update is called once per frame
    void Update()
    {

        //getting the coordinate of the mouse
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Check if user is clicking and get the coordinates if he does. Check also if he click on walkable ground or clickable object thanks to SceneInformation.shallPlayerMove
        if (Input.GetMouseButtonDown(0)&&SceneInformation.current.ShallCharacterMove)
        {
            target = new Vector2(mousePos.x, Mathf.Clamp(mousePos.y, SceneInformation.current.yMin, SceneInformation.current.yMax)); //Using Math.Clamp to avoid the character quit the walkable area.
        }
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime*speed);

        //Check if character is quiting the scene
        if ((transform.position.x < SceneInformation.current.xMin) && (SceneInformation.current.LeftLevel != ""))
        {
            SceneInformation.current.LoadNextScene(SceneInformation.current.LeftLevel);
        }
        if ((transform.position.x > SceneInformation.current.xMax) && (SceneInformation.current.RightLevel != ""))
        {
            SceneInformation.current.LoadNextScene(SceneInformation.current.RightLevel);
        }
    }

    public bool IsImmobile()
    {
        return ((transform.position.x == target.x)&&(transform.position.y==target.y));
    }
}
