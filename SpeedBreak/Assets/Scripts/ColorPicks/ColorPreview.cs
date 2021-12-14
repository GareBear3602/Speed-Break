using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPreview : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject redSpot;

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
        gameManager.RedPreview();
        redSpot.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        redSpot.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameManager.CarRed();
        redSpot.gameObject.SetActive(false);
    }
}
