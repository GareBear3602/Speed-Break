using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPreview : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject greenSpot;

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
        gameManager.GreenPreview();
        greenSpot.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        greenSpot.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameManager.CarGreen();
        greenSpot.gameObject.SetActive(false);
    }
}
