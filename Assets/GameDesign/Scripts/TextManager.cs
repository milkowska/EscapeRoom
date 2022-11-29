using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{   
    Text buttonText;
    public static string instruction;


    void Start()
    {
        buttonText = GetComponent<Text>();
    }

    void Update()
    {
        buttonText.text = instruction;
    }
}
