using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonController : MonoBehaviour
{
    [SerializeField]
    public Button playButton;

    // Use this for initialization
    void Start()
    {
        Button button = playButton.GetComponent<Button>();
        button.onClick.AddListener(LoadLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadLevel()
    {
        SceneManager.LoadScene("Game");
    }
}