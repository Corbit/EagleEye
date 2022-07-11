using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreTable : MonoBehaviour
{
    TimerController highscore;
    public Text HighscoreLv1;

    void Awake()
    {
        HighscoreLv1.text = PlayerPrefs.GetFloat("Highscore",0).ToString();
    }
}
