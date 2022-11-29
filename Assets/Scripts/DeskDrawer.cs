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

    SpriteRenderer sr;

    public static bool isDrawerOpen = false;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
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
            sr.sprite = drawerOpened;
            colliderOpen.SetActive(true);
            colliderClosed.SetActive(false);
            foundKey = true;
        }
        else
        {
            sr.sprite = drawerClosed;
            colliderOpen.SetActive(false);
            colliderClosed.SetActive(true);
        }
    }

    /* 
    public void TakeKey()
    {
        GameManager.instance.FoundKey();
        anim = GetComponent<Animator>();
    }

    public void OpenDrawer()
    {
        gameObject.SetActive(true);
    }

    public void CloseDrawer()
    {
        gameObject.SetActive(false);
    }
    */
}
