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
        textScore.text = TEXT_SCORE;
    }

    // Update is called once per frame


    void Update()
    {

    }
}
