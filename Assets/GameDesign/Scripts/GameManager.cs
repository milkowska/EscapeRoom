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
        } else if (instance != this) { 
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public GameObject key;
    
    public static bool isHammerPickedUp = false;
    public static bool isKeyPickedUp = false;
    public static bool isMapPickedUp = false;
    public static bool isScrewPickedUp = false;
    public static bool isGameFinished = false;

    public void WinGame()
    {
        isGameFinished = true;
        SceneManager.LoadScene("WinScene");
        Destroy(this.gameObject);
    }

    public void Reset()
    {
        isHammerPickedUp = false;
        isKeyPickedUp = false;
        isMapPickedUp = false;
        isScrewPickedUp = false;
        isGameFinished = false;
    }
}
