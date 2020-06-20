using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text lastScoreText;
    public Text highestScoreText;

    void Start()
    {
        lastScoreText.text = PlayerPrefs.GetInt("LastScore").ToString();
        highestScoreText.text = PlayerPrefs.GetInt("HighestScore").ToString();
    }
    
}
