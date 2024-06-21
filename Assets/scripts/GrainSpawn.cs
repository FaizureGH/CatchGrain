using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrainSpawn : MonoBehaviour
{
    public GameObject grain;
    public Transform spawnPoint;

    public float x;
    public float z;
    public float Y;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBall", 4f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ball, spawnPos, Quaternion.identity);


        }
        */
    }

    void SpawnBall()
    {
        float X = Random.Range(-x, x);
        float Z = Random.Range(-z, z);
        Vector3 randomSpawnPos = new Vector3(X, Y, Z);

        Instantiate(grain, randomSpawnPos, Quaternion.identity);
    }
}
