using System.Collections;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject pickupPrefab;
    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 1.5f;

    void Start()
    {
        StartCoroutine(SpawnPickups());
    }

    IEnumerator SpawnPickups()
    {
        float camHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;

        for (int i = 0; i < 10; i++)
        {
            float randomX = Random.Range(-camHalfWidth, camHalfWidth);
            Vector3 spawnPos = new Vector3(randomX, 6f, 0);

            Instantiate(pickupPrefab, spawnPos, Quaternion.identity);

            float wait = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(wait);
        }
    }
}
