using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerController : MonoBehaviour
{
    public static TimerController instance;
    public Text timeCounter;
    public String bestTime;
    public Text winTime;
    public Text Best;
    public float floatnumber = float.Parse("60");

    public bool win;


    private TimeSpan timePlaying;
    private bool timerGoing;
    private float elapsedTime;

    public GameObject Target;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        timeCounter.text = "00,00";
        timerGoing = false;
        BeginTimer();
        gethighscore();
    }

    void Update()
    {
        if (Target == null)
        {
            winTime.text = timeCounter.text;
            EndTimer();
            bestTime = winTime.text;
            floatnumber = float.Parse(bestTime);
            sethighscore();
            
        }
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "" + timePlaying.ToString("mm','ss");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }


    public void gethighscore()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore1", 59).ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore2", 59).ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level3")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore3", 59).ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore4", 59).ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level5")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore5", 59).ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level6")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore6", 59).ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level7")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore7", 59).ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level8")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore8", 59).ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level9")
        {
            if (Best != null)
            {
                Best.text = PlayerPrefs.GetFloat("HighScore9", 59).ToString();
            }
        }
    }

    public void sethighscore()
    {
        if(SceneManager.GetActiveScene().name == "Level1")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore1", 59))
            {
                PlayerPrefs.SetFloat("HighScore1", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore2", 59))
            {
                PlayerPrefs.SetFloat("HighScore2", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level3")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore3", 59))
            {
                PlayerPrefs.SetFloat("HighScore3", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore4", 59))
            {
                PlayerPrefs.SetFloat("HighScore4", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level5")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore5", 59))
            {
                PlayerPrefs.SetFloat("HighScore5", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level6")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore6", 59))
            {
                PlayerPrefs.SetFloat("HighScore6", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level7")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore7", 59))
            {
                PlayerPrefs.SetFloat("HighScore7", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level8")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore8", 59))
            {
                PlayerPrefs.SetFloat("HighScore8", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
        if (SceneManager.GetActiveScene().name == "Level9")
        {
            if (floatnumber < PlayerPrefs.GetFloat("HighScore9", 59))
            {
                PlayerPrefs.SetFloat("HighScore9", floatnumber);
                Best.text = floatnumber.ToString();
            }
        }
    }
}