using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkPreview : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject pinkSpot;

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
        gameManager.PinkPreview();
        pinkSpot.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        pinkSpot.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameManager.CarPink();
        pinkSpot.gameObject.SetActive(false);
    }
}
