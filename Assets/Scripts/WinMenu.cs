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

    private void Awake() {
        
        
 
    }

    void Update()
    {
        //Debug.Log(GameObject.FindGameObjectsWithTag("Target_Hit").Length);
        if(GameObject.FindGameObjectsWithTag("Target_Hit").Length == 0) {
            won = true;
        }
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScreen");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        won = !won;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
