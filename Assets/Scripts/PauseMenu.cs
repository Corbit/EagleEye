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

    public void Resume()
    {
        IsPaused = !IsPaused;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScreen");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        IsPaused = !IsPaused;
    }
}
