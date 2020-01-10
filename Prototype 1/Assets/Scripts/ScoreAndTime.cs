using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using TMPro;
using System;
using System.Globalization;

public class ScoreAndTime : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI finalText;
    public TextMeshProUGUI finalscore;
    public GameObject MainPanel;
    public GameObject LosePanel;
    public GameObject WinPanel;
    private float time;
    private int count;
    void Start()
    {
        if (MainMenu.camp == true)
        {
            count = 0;
            time = 15;
            finalText.text = "";
            settimeText();
            setCountText();
            Time.timeScale = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MainMenu.camp == true)
        {
            time -= Time.deltaTime;
            settimeText();
            if (time < 0)
            {
                timeText.text = "";
                finalText.text = "Game Over. Follow coins!";
                MainPanel.SetActive(false);
                LosePanel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    void OnCollisionEnter(Collision otherObj)
    {
        if (MainMenu.camp == true)
        {
            if (otherObj.gameObject.tag == "Coin")
            {
                otherObj.gameObject.SetActive(false);
                Destroy(otherObj.gameObject);

                count++;
                setCountText();
            }

            if (otherObj.gameObject.tag == "Time")
            {
                otherObj.gameObject.SetActive(false);
                Destroy(otherObj.gameObject);

                time += 10;
            }

            if (otherObj.gameObject.tag == "Won")
            {
                otherObj.gameObject.SetActive(false);
                Destroy(otherObj.gameObject);
                finalText.text = "You Won";
                finalscore.text = "Score " + count.ToString(); ;
                MainPanel.SetActive(false);
                WinPanel.SetActive(true);
                Time.timeScale = 0f;

            }
        }
    }
    void setCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
    void settimeText()
    {
        timeText.text = "Time: " + time.ToString("0.00", CultureInfo.InvariantCulture) + "s";
    }
}
