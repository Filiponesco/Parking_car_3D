using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text city;
    public void PlayGame()
    {
        SceneManager.LoadScene("City1");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(currentLevel, LoadSceneMode.Additive);
    }

    public void FreeRoam1()
    {
        SceneManager.LoadScene("City1");
    }
    public void FreeRoam2()
    {
        SceneManager.LoadScene("City2");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
