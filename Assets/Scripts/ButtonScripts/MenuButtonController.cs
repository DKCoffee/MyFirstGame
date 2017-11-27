﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour
{
    [SerializeField]
    public Button menuButton;

    // Use this for initialization
    void Start()
    {
        Button button = menuButton.GetComponent<Button>();
        button.onClick.AddListener(LoadLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadLevel()
    {
        SceneManager.LoadScene("Menu");
    }
}
