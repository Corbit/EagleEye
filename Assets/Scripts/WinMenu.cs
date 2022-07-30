using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
    //flag for won game
    public bool won;
    public GameObject uiWin;

    public GameObject btnNext;
   

    private void Start()
    {
        won = false;
        
        //checks if the last level is active and disables the "Next Level" button
        if(SceneManager.GetActiveScene().buildIndex == 9) {

            btnNext.SetActive(false);
        }
        
    }

    void Update()
    {
        //changes flag if no more targets are alive
        if(GameObject.FindGameObjectsWithTag("Target_Hit").Length == 0) {
            won = true;
        }
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
        won = !won;
    }

    //Starte das n�chste Level
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
