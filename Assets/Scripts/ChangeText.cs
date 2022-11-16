using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{ 
    public Text buttonText;
    private int digit = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            //delay
            IterateText();
        }

    }
    public void IterateText()
    {

        if (digit != 9)
        {
            Debug.Log("Changing to " + digit);
            buttonText.text = digit.ToString();
            digit++;
        }
        else
        {
            buttonText.text = digit.ToString();
            digit = 0;
        }
       
        
    }
}
