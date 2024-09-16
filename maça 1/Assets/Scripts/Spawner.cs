using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject maçaPrefab;
    public float spawnDelay = 1f;

    void Start()
    {
        StartCoroutine(SpawnApple());
    }

    IEnumerator SpawnApple() 
    {
        while (true) 
        {
            float randomXPosition = Random.Range(-8f, 8f);
            Vector3 spawnPosition = new Vector3(x: randomXPosition, y: 6f, z: 0);
            Instantiate(maçaPrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(1f);
        }
    }
}
