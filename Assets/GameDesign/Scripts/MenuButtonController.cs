using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public GameObject menu;

   public void opensMenu()
    {
        menu.SetActive(true);
        Debug.Log("Click");
    }
}
