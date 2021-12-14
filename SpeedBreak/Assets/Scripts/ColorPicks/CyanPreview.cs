using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanPreview : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject cyanSpot;

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
        gameManager.CyanPreview();
        cyanSpot.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        cyanSpot.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameManager.CarCyan();
        cyanSpot.gameObject.SetActive(false);
    }
}
