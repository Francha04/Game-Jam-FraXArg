using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversibleClikableObjectParent : MonoBehaviour
{
    public GameObject firstChild;
    public GameObject secondChild;

    // Start is called before the first frame update
    void Start()
    {
        SetGoodStateOfActivation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle()
    {
        DataBase.Instance.isIrreversibleClickableItemTemplateActivated = !DataBase.Instance.isIrreversibleClickableItemTemplateActivated;
        SetGoodStateOfActivation();
    }

    public void SetGoodStateOfActivation()
    {
        firstChild.SetActive(!DataBase.Instance.isIrreversibleClickableItemTemplateActivated);
        secondChild.SetActive(DataBase.Instance.isIrreversibleClickableItemTemplateActivated);
    }
}
