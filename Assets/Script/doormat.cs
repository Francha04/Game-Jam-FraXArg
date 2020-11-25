using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doormat : MonoBehaviour
{
    public GameObject newState;
    public GameObject key;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void ClickReaction()
    {
        newState.SetActive(true);
        key.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
