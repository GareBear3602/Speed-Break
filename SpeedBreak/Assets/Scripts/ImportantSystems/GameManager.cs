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
    public GameObject scoreSystem;
    public GameObject lapSystem;

    //Instructions
    public GameObject instructions;
    public Button letsGo;

    //Camera Stuff
    public GameObject firstCamera;
    public GameObject lastCamera;

    //Extras
    public GameObject perfectTrophy;
    public GameObject trophy;
    private Vector3 spawnPos = new Vector3(0f, 0.7f, -60);
    public float spawnPosY = 0.7f;
    public float spawnPosZ = 35f;

    //Colors
    public GameObject blueCar;
    public GameObject redCar;
    public GameObject tangCar;
    public GameObject vioCar;

    public GameObject redButton;
    public GameObject blueButton;
    public GameObject tangButton;
    public GameObject vioButton;

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
        blueButton.gameObject.SetActive(false);
        redButton.gameObject.SetActive(false);
        vioButton.gameObject.SetActive(false);
        tangButton.gameObject.SetActive(false);
        firstCamera.gameObject.SetActive(false);
        lapSystem.gameObject.SetActive(true);
        scoreSystem.gameObject.SetActive(true);
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
        PlayerPrefs.SetFloat("Score", score);
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

    public void ColorPick()
    {
        instructions.gameObject.SetActive(false);
        letsGo.gameObject.SetActive(false);
        blueButton.gameObject.SetActive(true);
        redButton.gameObject.SetActive(true);
        vioButton.gameObject.SetActive(true);
        tangButton.gameObject.SetActive(true);
    }

    public void CarBlue()
    {
        Instantiate(blueCar, spawnPos, transform.rotation);
        StartGame();
    }

    public void CarRed()
    {
        Instantiate(redCar, spawnPos, transform.rotation);
        StartGame();
    }

    public void CarViolet()
    {
        Instantiate(vioCar, spawnPos, transform.rotation);
        StartGame();
    }

    public void CarTangerine()
    {
        Instantiate(tangCar, spawnPos, transform.rotation);
        StartGame();
    }
}
