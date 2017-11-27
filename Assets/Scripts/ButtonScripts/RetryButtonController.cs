using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButtonController : MonoBehaviour
{
    [SerializeField]
    public Button retryButton;

    // Use this for initialization
    void Start()
    {
        Button button = retryButton.GetComponent<Button>();
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