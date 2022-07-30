using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //flag if the game is paused
    public bool IsPaused;
    public GameObject PauseUI;

    private void Start() {
        IsPaused = false;
    }

  
    void Update()
    {
        //changes flag
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }
    }


    //Resume Game
    public void Resume()
    {
        IsPaused = !IsPaused;
    }


    //Zur�ck ins Main Menu
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScreen");
    }

    //Restart Level
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        IsPaused = !IsPaused;
    }
}
