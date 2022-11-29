using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    private bool isFixed = false;
    private Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnMouseDown()
    {
        if (GameManager.isHammerPickedUp && GameManager.isScrewPickedUp)
        {
            isFixed = !isFixed;
            Debug.Log("Fixed");
            anim.SetTrigger("fixed");
        }
    }
}
