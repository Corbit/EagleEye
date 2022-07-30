using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool IsPaused;
    public GameObject PauseUI;

    private void Start() {
        IsPaused = false;
    }

  
    void Update()
    {
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


    //Zurück ins Main Menu
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
