using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
      
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
    public void quit()
    {
        SceneManager.LoadScene("Menu");
    }
}
