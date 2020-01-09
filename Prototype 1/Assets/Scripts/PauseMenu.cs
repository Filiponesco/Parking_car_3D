using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        GameIsPaused = false;
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void Next1()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level2", LoadSceneMode.Additive);
    }
    public void Next2()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level3", LoadSceneMode.Additive);
    }
    public void Next3()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("City2");   
    }

    public void Restart1()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Restart");
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
    }
    public void Restart2()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Restart");
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level2", LoadSceneMode.Additive);
    }
    public void Restart3()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Restart");
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level3", LoadSceneMode.Additive);
    }

}
