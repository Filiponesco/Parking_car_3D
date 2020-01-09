using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text city;
    public static bool camp = false;
    public void PlayGame()
    {
        SceneManager.LoadScene("City1");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
        camp = true;
    }

    public void FreeRoam1()
    {
        camp = false;
        SceneManager.LoadScene("City1");
        SceneManager.LoadScene("FreeRoam1", LoadSceneMode.Additive);
    }
    public void FreeRoam2()
    {
        camp = false;
        SceneManager.LoadScene("City2");
        SceneManager.LoadScene("FreeRoam2", LoadSceneMode.Additive);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
