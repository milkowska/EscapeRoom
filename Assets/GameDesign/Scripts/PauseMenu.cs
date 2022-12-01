using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused; 
    public GameObject MidMenuUI;

     void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        MidMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void Resume()
    {
        MidMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void MainMenu()
    {
     
        SceneManager.LoadScene("StartScreen");
    }
    public void RestartGame()
    {
        InventoryManager.Instance.Reset();
        InventoryManager.Instance.destroyInventory();
        GameManager.instance.Reset();
        SceneManager.LoadScene("StartScreen");

    }
}
