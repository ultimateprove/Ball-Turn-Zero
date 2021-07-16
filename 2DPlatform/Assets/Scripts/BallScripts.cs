using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScripts : MonoBehaviour
{
    public int score;
    public int hightScrore;
    [SerializeField] Text scoreText;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Bonus"))
        {
            Destroy(other.gameObject);
            UpScore();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene(2);
        }

    }
    
    private void UpScore() {
        score++;
        scoreText.text = score.ToString();
    }

}
