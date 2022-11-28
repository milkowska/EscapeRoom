using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskDrawer : MonoBehaviour
{
    public GameObject keyObject;

    public Sprite drawerClosed;
    public Sprite drawerOpened;

    public GameObject colliderOpen;
    public GameObject colliderClosed;


    SpriteRenderer sr;

    public static bool isDrawerOpen = false;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isDrawerOpen)
        {
            sr.sprite = drawerOpened;
            colliderOpen.SetActive(true);
            colliderClosed.SetActive(false);
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
