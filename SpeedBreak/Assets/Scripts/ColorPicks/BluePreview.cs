using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePreview : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject blueSpot;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        gameManager.BluePreview();
        blueSpot.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        blueSpot.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameManager.CarBlue();
        blueSpot.gameObject.SetActive(false);
    }
}
