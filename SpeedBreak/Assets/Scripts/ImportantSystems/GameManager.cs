using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
        if (score > best)
        {
            best = score;
            besttext.text = "Best: " + best;
        }
    }
}
