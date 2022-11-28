using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject description;
    public bool foundKey = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            description.SetActive(true);
            StartCoroutine(DelayCoroutine());
        }

    }

    IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(3);
        description.SetActive(false);
    }
    
    public void Show()
    {
        foundKey = true;
        key.SetActive(true);
    }

    public void Hide()
    {
        key.SetActive(false);
    }

}
