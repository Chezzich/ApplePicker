using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenContoller : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("Difficult", 0);
    }

    public void StartBtnOnClick()
    {
        SceneManager.LoadScene("Scene_0");
    }

    public void ChangeDifficult(int difficult)
    {
        PlayerPrefs.SetInt("Difficult", difficult);
    }
}
