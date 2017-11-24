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
        score = 0;
        UpdateScore ();
    }

    private void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    private void UpdateScore()
    {
        textScore.text = "Score: " + score;
    }
}
