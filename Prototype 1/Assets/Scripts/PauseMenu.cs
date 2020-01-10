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
        if (MainMenu.camp == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
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
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level4", LoadSceneMode.Additive);
    }
    public void Next4()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level5", LoadSceneMode.Additive);
    }
    public void Next5()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("City2");
        SceneManager.LoadScene("Level6", LoadSceneMode.Additive);
    }
    public void Next6()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("City2");
        SceneManager.LoadScene("Level7", LoadSceneMode.Additive);
    }
    public void Next7()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("City2");
        SceneManager.LoadScene("Level8", LoadSceneMode.Additive);
    }
    public void Next8()
    {
        GameIsPaused = false;
        SceneManager.LoadScene("Finish");
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
    public void Restart4()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Restart");
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level4", LoadSceneMode.Additive);
    }
    public void Restart5()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Restart");
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("Level5", LoadSceneMode.Additive);
    }
    public void Restart6()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Restart");
        SceneManager.LoadScene("City2");
        SceneManager.LoadScene("Level6", LoadSceneMode.Additive);
    }
    public void Restart7()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Restart");
        SceneManager.LoadScene("City2");
        SceneManager.LoadScene("Level7", LoadSceneMode.Additive);
    }
    public void Restart8()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Restart");
        SceneManager.LoadScene("City2");
        SceneManager.LoadScene("Level8", LoadSceneMode.Additive);
    }

}
