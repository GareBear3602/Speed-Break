using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTriggerSpawnTHREE : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject pointPrefab;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Instantiate(pointPrefab, PointSpawn(), pointPrefab.transform.rotation);
        Instantiate(pointPrefab, PointSpawn(), pointPrefab.transform.rotation);
        Instantiate(pointPrefab, PointSpawn(), pointPrefab.transform.rotation);
        Instantiate(pointPrefab, PointSpawn(), pointPrefab.transform.rotation);
    }

    private Vector3 PointSpawn()
    {
        float SpawnPosX = Random.Range(1680, 1720);
        float SpawnPosZ = Random.Range(-500, 500);
        Vector3 randomPos = new Vector3(SpawnPosX, 0, SpawnPosZ);
        return randomPos;
    }
}
