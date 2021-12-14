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
    public GameObject exampleCar;
    public GameObject playerCar;

    //Colors
    public GameObject blueCar;
    public GameObject redCar;
    public GameObject tangCar;
    public GameObject vioCar;

    public Material redColor;
    public Material blueColor;
    public Material tangColor;
    public Material vioColor;
    public Material perriColor;
    public Material greenColor;
    public Material pinkColor;
    public Material cyanColor;

    public GameObject rPreview;
    public GameObject bPreview;
    public GameObject tPreview;
    public GameObject vPreview;
    public GameObject pPreview;
    public GameObject gPreview;
    public GameObject pkPreview;
    public GameObject cPreview;

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
        rPreview.gameObject.SetActive(false);
        bPreview.gameObject.SetActive(false);
        tPreview.gameObject.SetActive(false);
        vPreview.gameObject.SetActive(false);
        pPreview.gameObject.SetActive(false);
        gPreview.gameObject.SetActive(false);
        pkPreview.gameObject.SetActive(false);
        cPreview.gameObject.SetActive(false);

        firstCamera.gameObject.SetActive(false);
        exampleCar.gameObject.SetActive(false);
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
        rPreview.gameObject.SetActive(true);
        bPreview.gameObject.SetActive(true);
        tPreview.gameObject.SetActive(true);
        vPreview.gameObject.SetActive(true);
        pPreview.gameObject.SetActive(true);
        gPreview.gameObject.SetActive(true);
        pkPreview.gameObject.SetActive(true);
        cPreview.gameObject.SetActive(true);


        exampleCar.gameObject.SetActive(true);
        instructions.gameObject.SetActive(false);
        letsGo.gameObject.SetActive(false);
    }
    
    //Picks the Car Colors
    public void CarBlue()
    {
        playerCar.GetComponent<MeshRenderer>().material = blueColor;
        StartGame();
    }

    public void CarRed()
    {
        playerCar.GetComponent<MeshRenderer>().material = redColor;
        StartGame();
    }

    public void CarViolet()
    {
        playerCar.GetComponent<MeshRenderer>().material = vioColor;
        StartGame();
    }

    public void CarTangerine()
    {
        playerCar.GetComponent<MeshRenderer>().material = tangColor;
        StartGame();
    }

    public void CarPerriwinkle()
    {
        playerCar.GetComponent<MeshRenderer>().material = perriColor;
        StartGame();
    }

    public void CarGreen()
    {
        playerCar.GetComponent<MeshRenderer>().material = greenColor;
        StartGame();
    }

    public void CarPink()
    {
        playerCar.GetComponent<MeshRenderer>().material = pinkColor;
        StartGame();
    }

    public void CarCyan()
    {
        playerCar.GetComponent<MeshRenderer>().material = cyanColor;
        StartGame();
    }

    //Previews the Car Colors
    public void RedPreview()
    {
        exampleCar.GetComponent<MeshRenderer>().material = redColor;
    }

    public void BluePreview()
    {
        exampleCar.GetComponent<MeshRenderer>().material = blueColor;
    }

    public void TangPreview()
    {
        exampleCar.GetComponent<MeshRenderer>().material = tangColor;
    }

    public void VioPreview()
    {
        exampleCar.GetComponent<MeshRenderer>().material = vioColor;
    }

    public void PerriPreview()
    {
        exampleCar.GetComponent<MeshRenderer>().material = perriColor;
    }

    public void GreenPreview()
    {
        exampleCar.GetComponent<MeshRenderer>().material = greenColor;
    }

    public void PinkPreview()
    {
        exampleCar.GetComponent<MeshRenderer>().material = pinkColor;
    }

    public void CyanPreview()
    {
        exampleCar.GetComponent<MeshRenderer>().material = cyanColor;
    }
}
