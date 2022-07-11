using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;
    public Text timeCounter;
    public String bestTime;
    public Text winTime;
    public Text Best;
    public float floatnumber = float.Parse("60");
    public Text Second;
    public Text Third;

    private TimeSpan timePlaying;
    private bool timerGoing;
    private float elapsedTime;

    public GameObject Target;
    public GameObject WinScreen;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        timeCounter.text = "00,00";
        timerGoing = false;
        BeginTimer();
        if (Best != null)
        {
            Best.text = PlayerPrefs.GetFloat("HighScore", 59).ToString();
        }
    }

    void Update()
    {
        if (Target == null)
        {
            winTime.text = timeCounter.text;
            EndTimer();
            bestTime = winTime.text;
            floatnumber = float.Parse(bestTime);
            Debug.Log(bestTime);
            Debug.Log(floatnumber);
            if (floatnumber < PlayerPrefs.GetFloat("HighScore", 59))
            {
                PlayerPrefs.SetFloat("HighScore", floatnumber);
                Best.text = floatnumber.ToString();
            }
            WinScreen.SetActive(true);
            Time.timeScale = 0f;           
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
            string timePlayingStr = "" + timePlaying.ToString("ss','ff");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }

    private void OnGUI()
    {
        if(GUI.Button(new Rect(100, 200, 200,  60), "Delete"))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}