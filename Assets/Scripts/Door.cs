using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public Text description;
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