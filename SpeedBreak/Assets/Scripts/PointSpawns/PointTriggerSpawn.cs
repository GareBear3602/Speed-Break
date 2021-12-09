using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTriggerSpawn : MonoBehaviour
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
        float SpawnPosX = Random.Range(500, 1150);
        float SpawnPosZ = Random.Range(1032, 1065);
        Vector3 randomPos = new Vector3(SpawnPosX, 0, SpawnPosZ);
        return randomPos;
    }
}
