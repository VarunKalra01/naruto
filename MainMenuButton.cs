using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuButton : MonoBehaviour
{
    public Button mainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        Debug.Log("Main Menu Button Clicked");
        SceneManager.LoadScene("GameStartScene");
        Time.timeScale = 1f;
    }
}
