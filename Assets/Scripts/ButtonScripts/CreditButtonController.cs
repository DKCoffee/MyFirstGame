using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditButtonController : MonoBehaviour

{
    [SerializeField]
    public Button creditButton;

    // Use this for initialization
    void Start()
    {
        Button button = creditButton.GetComponent<Button>();
        button.onClick.AddListener(LoadLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadLevel()
    {
        SceneManager.LoadScene("Credits");
    }
}