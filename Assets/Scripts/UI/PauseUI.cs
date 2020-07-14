using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseUI;

    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPause)
            {
                FindObjectOfType<AudioManager>().Play("Theme");
                FindObjectOfType<AudioManager>().Stop("Pause");
                Resume();
            }
            else
            {
                FindObjectOfType<AudioManager>().Pause("Theme");
                FindObjectOfType<AudioManager>().Play("Pause");
               
                Pause();
            }

        }
     


    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Pause");
        
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void Resume()
    {
        FindObjectOfType<AudioManager>().Stop("Pause");
        FindObjectOfType<AudioManager>().Play("Theme");
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    public void Restart()
    {
        FindObjectOfType<AudioManager>().Stop("Pause");
        GameIsPause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void quit()
    {
        FindObjectOfType<AudioManager>().Stop("Pause");
        SceneManager.LoadScene("Menu");
    }
}


