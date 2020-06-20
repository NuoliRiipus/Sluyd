using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float slowness = 10f;
    bool gameHasEnded = false;
    public Text score;

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            //ScorePanel.SetActive(true);
            gameHasEnded = true;
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        PlayerPrefs.SetInt("LastScore", Convert.ToInt32(score.text));
        if (PlayerPrefs.GetInt("LastScore") > PlayerPrefs.GetInt("HighestScore"))
        {
            PlayerPrefs.SetInt("HighestScore", PlayerPrefs.GetInt("LastScore"));
        }

        SceneManager.LoadScene("Menu");
    }

}
