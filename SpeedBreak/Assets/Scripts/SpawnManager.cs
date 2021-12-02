using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pointPrefab;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.runGame)
        {
            Instantiate(pointPrefab, PointSpawn(), pointPrefab.transform.rotation);
        }
    }

    private Vector3 PointSpawn()
    {
        float SpawnPosX = Random.Range(500, 1150);
        float SpawnPosZ = Random.Range(1032, 1065);
        Vector3 randomPos = new Vector3(SpawnPosX, 0, SpawnPosZ);
        return randomPos;
    }
}
