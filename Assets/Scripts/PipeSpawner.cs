using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 2f;
    public float heightRange = 0.5f;

    public GameObject pipe;
    private float timer;


    private void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange), 0);
        GameObject newPipe = Instantiate(pipe, spawnPosition, transform.rotation);
        Destroy(newPipe, 5f);
    }

    private void Update()
    {
        if(timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
