using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseScene : MonoBehaviour
{
    [SerializeField] Text Score;

    public void ShowScore()
    {
        Score.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToMAinMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Start() {
        ShowScore();
    }
}
