using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour {

    [SerializeField] public Button exitButton;

    // Use this for initialization
    void Start()
    {
        Button button = exitButton.GetComponent<Button>();
        button.onClick.AddListener(doQuit);
    }

    // Update is called once per frame
    void Update() {

    }

    public void doQuit()
    {
        Application.Quit();
    }

}
