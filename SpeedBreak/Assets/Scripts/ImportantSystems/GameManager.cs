using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Lap Stuff
    public TextMeshProUGUI laptext;
    public float lapcount;
    private float lap;
    public GameObject lapTrigger;
    public GameObject finalTrigger;

    //Main Menu
    public Button mainMenu;
    public GameObject mainBack;

    //End Menu
    public GameObject endScreen;
    public Button restart;
    public TextMeshProUGUI endScore;
    public TextMeshProUGUI endBest;

    //Game Run
    public bool runGame;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI besttext;

    //Scoring
    public float score = 0;
    public float best;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (lap == 3)
        {
            lapTrigger.gameObject.SetActive(false);
            finalTrigger.gameObject.SetActive(true);
        }
    }

    public void UpdateLap(int lapAdd)
    {
        lap += lapAdd;
        laptext.text = "Lap: " + lap + "/3";
    }

    public void UpdateScore(int scoreAdd)
    {
        score += scoreAdd;
        scoretext.text = "Score: " + score;
    }

    public void StartGame()
    {
        mainMenu.gameObject.SetActive(false);
        mainBack.gameObject.SetActive(false);
        runGame = true;
        UpdateLap(1);
    }

    public void EndGame()
    {
        runGame = false;
        endScreen.gameObject.SetActive(true);
        endScore.gameObject.SetActive(true);
        endBest.gameObject.SetActive(true);
        endScore.text = "Score: " + score;
        endBest.text = "Best: " + best;
        restart.gameObject.SetActive(true);
        if (score > best)
        {
            best = score;
            besttext.text = "Best: " + best;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
