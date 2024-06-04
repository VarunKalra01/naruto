using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResumeScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button resumeButton;
    // Start is called before the first frame update
    void Start()
    {
        resumeButton.onClick.AddListener(ResumeGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResumeGame()
    {
        // Debug.Log("Resume Button Clicked");
        // Time.timeScale = 1f;
        // gameObject.SetActive(false);
        Debug.Log("Resume button clicked");
        Time.timeScale = 1f;
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
    }
}
