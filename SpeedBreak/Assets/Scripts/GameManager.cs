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

    // Start is called before the first frame update
    void Start()
    {
        UpdateLap(1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateLap(int lapAdd)
    {
        lap += lapAdd;
        laptext.text = "Lap: " + lap + "/3";
    }
}
