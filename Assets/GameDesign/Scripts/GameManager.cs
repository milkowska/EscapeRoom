using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public GameObject key;
    public bool foundKey = false;
    public static bool isHammerPickedUp = false;
    public static bool isKeyPickedUp = false;
    public static bool isMapPickedUp = false;
    public static bool isScrewPickedUp = false;
    // dodac hammer tez?

    public void FoundKey()
    {
        foundKey = true;
    }



    public void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }

}