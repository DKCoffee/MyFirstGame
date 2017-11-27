using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    public Text scoreSave;
    public Text highscore;


    // Use this for initialization
    void Start()
    {
        scoreSave.text = PlayerPrefs.GetInt("Score", 0).ToString();
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore()
    {
        score++;
        scoreSave.text = score.ToString();
        PlayerPrefs.SetInt("Score", score);
        if(score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highscore.text = score.ToString();
        }
        if(score >= 30)
        {
            SceneManager.LoadScene("Victory");
        }
    }

}
