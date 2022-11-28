using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    bool isOpen = false;
    private Animator anim;
    public string Scene;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnMouseDown()
    {
        if (isOpen)
        {
            SceneManager.LoadScene(Scene);
        }

        isOpen = !isOpen;
        Debug.Log("Clicked door");
        anim.SetTrigger("DoorOpen");
    }
}