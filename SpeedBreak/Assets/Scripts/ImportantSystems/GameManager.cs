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
    public float lapPosZ = 44.5f;
    public float lapPosY = 2.5f;

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
    public float pointAdd = 1.0f;

    //Instructions
    public GameObject instructions;
    public Button letsGo;

    //Camera Stuff
    public GameObject firstCamera;
    public GameObject lastCamera;

    //Extras
    public GameObject perfectTrophy;
    public GameObject trophy;

    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "Score: " + score;
        besttext.text = "Rings: " + best + "/42";
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
        best += pointAdd;
        scoretext.text = "Score: " + score;
        besttext.text = "Rings: " + best + "/42";
    }

    public void StartGame()
    {
        instructions.gameObject.SetActive(false);
        letsGo.gameObject.SetActive(false);
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
        endBest.text = "Rings: " + best + "/42";
        restart.gameObject.SetActive(true);
        lastCamera.gameObject.SetActive(true);
        firstCamera.gameObject.SetActive(false);
        trophy.gameObject.SetActive(true);
        if (best == 42)
        {
            perfectTrophy.gameObject.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LapMoveUp()
    {
        lapTrigger.transform.position = new Vector3(0, 8, -lapPosZ);
        finalTrigger.transform.position = new Vector3(0, lapPosY, -100);
    }

    public void LapMoveDown()
    {
        lapTrigger.transform.position = new Vector3(0, lapPosY, -lapPosZ);
        finalTrigger.transform.position = new Vector3(0, lapPosY, -lapPosZ);
    }

    public void Instructions()
    {
        instructions.gameObject.SetActive(true);
        letsGo.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
        mainBack.gameObject.SetActive(false);

    }
}
