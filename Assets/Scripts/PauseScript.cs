﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    [SerializeField]
    private GameObject pausePanel;
    [SerializeField]
    private GameObject uiGameText;

    private bool isInPause = false;

    private static PauseScript instance;

    public static PauseScript Instance
    {
        get
        {
            return instance;
        }
    }

    public void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Pause") && !isInPause)
        {
            isInPause = true;
            pausePanel.SetActive(true);
            uiGameText.SetActive(false);
            Time.timeScale = 0;
        }
    }
    public void OnResumeGameButtonDown()
    {
        isInPause = false;
        pausePanel.SetActive(false);
        uiGameText.SetActive(true);
        Time.timeScale = 1;
    }
}
