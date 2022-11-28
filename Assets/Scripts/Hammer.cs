using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hammer : MonoBehaviour
{
    public bool isClicked;
    public GameObject description;

    // Start is called before the first frame update
    void Start()
    {
       // isClicked = false;
        description.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isClicked = true;
            description.SetActive(true);
            StartCoroutine(DelayCoroutine());
        }
        
    } 
    
    IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(3);
        description.SetActive(false);
    }

    }
    