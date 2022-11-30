using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeskDrawer : MonoBehaviour
{
    public Text description;
    public GameObject keyObject;
    private bool foundKey = false;

    public Sprite drawerClosed;
    public Sprite drawerOpened;

    public GameObject colliderOpen;
    public GameObject colliderClosed;

    SpriteRenderer spriteR;

    public static bool isDrawerOpen = false;

    private void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        keyObject.SetActive(false);
    }

    private void Update()
    {
        
        if (isDrawerOpen)
        {
            if (!foundKey)
            {
                keyObject.SetActive(true);
            }
            spriteR.sprite = drawerOpened;
            colliderOpen.SetActive(true);
            colliderClosed.SetActive(false);
            foundKey = true;

        }
        else
        {
            spriteR.sprite = drawerClosed;
            colliderOpen.SetActive(false);
            colliderClosed.SetActive(true);
 
        }
    }
   
}
