using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public bool isOpen;
    private Animator anim;
    private SceneManager currentScene;

    public void Start()
    {
        isOpen = false;
        anim = GetComponentInChildren<Animator>();
    }

 
    public void Update()
    {
       
    }


    public void OnMouseDown()
    {
        Debug.Log("Clicked on object!");
        if (isOpen == false)
        {
            anim.SetTrigger("DoorOpen");
            isOpen = true;
            SceneManager.LoadScene("SecondRoom");
        } 
        
    }

}