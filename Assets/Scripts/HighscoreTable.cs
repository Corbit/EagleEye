using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreTable : MonoBehaviour
{
    TimerController highscore;
    public Text HighscoreLv1;
    public Text HighscoreLv2;
    public Text HighscoreLv3;
    public Text HighscoreLv4;
    public Text HighscoreLv5;
    public Text HighscoreLv6;
    public Text HighscoreLv7;
    public Text HighscoreLv8;
    public Text HighscoreLv9;

    void Awake()
    {
        HighscoreLv1.text = PlayerPrefs.GetFloat("HighScore1", 59).ToString();
        HighscoreLv2.text = PlayerPrefs.GetFloat("HighScore2", 59).ToString();
        HighscoreLv3.text = PlayerPrefs.GetFloat("HighScore3", 59).ToString();
        HighscoreLv4.text = PlayerPrefs.GetFloat("HighScore4", 59).ToString();
        HighscoreLv5.text = PlayerPrefs.GetFloat("HighScore5", 59).ToString();
        HighscoreLv6.text = PlayerPrefs.GetFloat("HighScore6", 59).ToString();
        HighscoreLv7.text = PlayerPrefs.GetFloat("HighScore7", 59).ToString();
        HighscoreLv8.text = PlayerPrefs.GetFloat("HighScore8", 59).ToString();
        HighscoreLv9.text = PlayerPrefs.GetFloat("HighScore9", 59).ToString();
    }
}
