using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskDrawer : MonoBehaviour
{

    public GameObject keyObject;

    public void TakeKey()
    {
        GameManager.instance.FoundKey();
    }

    public void OpenDrawer()
    {
        gameObject.SetActive(true);
    }

    public void CloseDrawer()
    {
        gameObject.SetActive(false);
    }

}
