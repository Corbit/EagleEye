using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
    public bool won;
    public GameObject uiWin;

    public GameObject btnNext;
   

    private void Start()
    {
        won = false;
        
        if(SceneManager.GetActiveScene().buildIndex == 9) {

            btnNext.SetActive(false);
        }
        
    }

    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Target_Hit").Length == 0) {
            won = true;
        }
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
        won = !won;
    }

    //Starte das nächste Level
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
