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

    private float targetTime = 20.0f;
    [SerializeField] private GunScript gunScript;
    [SerializeField] private GunScript gunScript1;
    [SerializeField] private GunScript gunScript2;
    [SerializeField] private GunScript gunScript3;
    [SerializeField] private GunScript gunScript4;
    [SerializeField] private GameObject army;
    [SerializeField] private GameObject gun;
    private EnnemyScript ennemyScript;
    private GameManager gameManager;
    public bool Cheating = true;

    private void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            IsCheating();
            targetTime = 20.0f;
        }
        else if (Cheating == false)
        {
            NotCheating();
            targetTime = 20.0f;
        }
    }


    // Use this for initialization
    void Start()
    {
        scoreSave.text = PlayerPrefs.GetInt("Score", 0).ToString();
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
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
        /*if(score >= 30)
        {
            SceneManager.LoadScene("Victory");
        }
        */
    }

    void IsCheating()
    {
        army.gameObject.SetActive(true);
        gun.gameObject.SetActive(true);
        gunScript.StartShoot();
        gunScript1.StartShoot();
        gunScript2.StartShoot();
        gunScript3.StartShoot();
        gunScript4.StartShoot();
    }

    void NotCheating()
    {
        Cheating = true;
    }
}
