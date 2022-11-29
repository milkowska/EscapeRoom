using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string id;
    bool isOpen = false;
    private Animator anim;
    public string Scene;
    private bool hasKey = false;

    public void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (id == "DoorOut" && !GameManager.isKeyPickedUp) 
            {
                TextManager.instruction = "The door is locked!";
                Debug.Log("Closed door, you need a key");
            }
             else if(id == "DoorIn") {

                TextManager.instruction = "This is a door!";
                Debug.Log("This is an open door");
            }
        }
    }
    private void OnMouseExit()
    {
        TextManager.instruction = "";
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
        TextManager.instruction = "";
    }
}