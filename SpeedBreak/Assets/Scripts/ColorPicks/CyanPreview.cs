using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanPreview : MonoBehaviour
{
    private GameManager gameManager;

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
    }

    private void OnMouseDown()
    {
        gameManager.CarCyan();
    }
}
