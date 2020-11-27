using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public bool ShallCharacterMove = true; //Help to know if character have to move at each click.
    public int clickableData;
    public int inventoryData;

    // Start is called before the first frame update
    void Awake()
    {
        current = this;
        clickableData = PlayerPrefs.GetInt("clickableData");
        inventoryData = PlayerPrefs.GetInt("inventoryData");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextScene(string NextSceneName) 
    {
        if (NextSceneName == LeftLevel) PlayerPrefs.SetInt("startingSide", -1);
        else if (NextSceneName == RightLevel) PlayerPrefs.SetInt("startindSide", 1);
        else PlayerPrefs.SetInt("startindSide", 0);
        SceneManager.LoadScene(NextSceneName);
    }


    //Was used in an older solution.
    public static int PowerOfTwo(int n)
    {
        if (n < 0) return -1;
        int res = 1;
        for (int i = 0; i < n; i++)
        {
            res *= 2;
        }
        return res;
    }

    /// <summary>
    /// Return the boolean correspondig to the <paramref name="n"/>th bit fo the integer <paramref name="data"/>. This function was used in an older solution.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static bool GetNthBoolean(int data, int n)
    {
        int dataAtGoodBit = data/PowerOfTwo(n);
        int almostBool = dataAtGoodBit % 2;
        return (almostBool == 1);
    }
}
