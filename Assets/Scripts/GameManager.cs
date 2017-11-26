using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField] private Text scoreSave;
    [SerializeField] private Text highscore;


    // Use this for initialization
    void Start()
    {
        scoreSave.text = PlayerPrefs.GetInt("ScoreSave", 0).ToString();
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

        if(score > PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.GetInt("Highscore", score);
            highscore.text = score.ToString();
        }
        if(score >= 30)
        {
            SceneManager.LoadScene("Victory");
        }
    }

}
