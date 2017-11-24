using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;

    [SerializeField]
    private Text textScore;

    private const string TEXT_SCORE = "Score : ";

    // Use this for initialization
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddScore()
    {
        score++;
        textScore.text = "Score: " + score;
        if(score >= 30)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

}
