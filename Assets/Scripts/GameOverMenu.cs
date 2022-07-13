using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    private Shooting shooting;
    [SerializeField] public GameObject uiGameOver;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        shooting = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>();
        gameOver = false;
        uiGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(shooting.magazine == 0 && GameObject.FindGameObjectsWithTag("Bullet").Length == 0) {
            gameOver = true;
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
        gameOver = !gameOver;
    }
}
