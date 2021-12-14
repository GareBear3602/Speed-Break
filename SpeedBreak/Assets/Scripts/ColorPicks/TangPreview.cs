using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangPreview : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject tangSpot;

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
        gameManager.TangPreview();
        tangSpot.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        tangSpot.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameManager.CarTangerine();
        tangSpot.gameObject.SetActive(false);
    }
}
