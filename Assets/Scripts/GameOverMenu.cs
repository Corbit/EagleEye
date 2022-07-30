using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    private Shooting shooting;

    ArrayList nonTargets = new ArrayList();
    int startint;

    [SerializeField] public GameObject uiGameOver;
    public bool gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i <= 4; i++) {
            nonTargets.AddRange(GameObject.FindGameObjectsWithTag("Animal_"+i));
        }  
        startint = nonTargets.Count;

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

        /*
         *   Collects all animal go. If this count change, it is presumed, that an animal was destroyed and the game ends 
         */
        nonTargets = new ArrayList();
        for (int i = 1; i <= 4; i++)
        {
            nonTargets.AddRange(GameObject.FindGameObjectsWithTag("Animal_" + i));
        }
        //Debug.Log(nonTargets.Count);
        if(startint != nonTargets.Count) {
            gameOver = true;
        }

    }

    //Zurück ins Menü
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScreen");
    }

    //Restart Level
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOver = !gameOver;
    }
}
