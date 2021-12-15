using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTriggerSpawnTWO : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject pointPrefab;
    public GameObject pointPrefabTwo;

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
        Instantiate(pointPrefabTwo, PointSpawn(), pointPrefab.transform.rotation);
        Instantiate(pointPrefabTwo, PointSpawn(), pointPrefab.transform.rotation);
        Instantiate(pointPrefabTwo, PointSpawn(), pointPrefab.transform.rotation);
        Instantiate(pointPrefabTwo, PointSpawn(), pointPrefab.transform.rotation);
    }

    private Vector3 PointSpawn()
    {
        float SpawnPosX = Random.Range(200, 1550);
        float SpawnPosZ = Random.Range(-920, -880);
        Vector3 randomPos = new Vector3(SpawnPosX, 0, SpawnPosZ);
        return randomPos;
    }
}
