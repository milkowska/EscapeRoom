using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else {
            Destroy(this);
        }
    }

    public GameObject key;
    public bool foundKey = false;

    public void FoundKey()
    {
        foundKey = true;
    }

    public void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }

}
