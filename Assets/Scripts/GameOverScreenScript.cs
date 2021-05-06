using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreenScript : MonoBehaviour
{
    public Text HighScoreText;
    public GameObject NewRecordTextGameObject;

    public void Awake()
    {
        gameObject.SetActive(true);
        HighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        if (PlayerPrefs.HasKey("NewRecord"))
            NewRecordTextGameObject.SetActive(PlayerPrefs.GetInt("NewRecord") == 1);
        PlayerPrefs.SetInt("New Record", 0);
    }

    public void PlayAgainButtonOnClick()
    {
        SceneManager.LoadScene("Scene_0");
    }
}
