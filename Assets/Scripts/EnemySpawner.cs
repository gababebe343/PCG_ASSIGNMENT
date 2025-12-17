using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<ObstacleWave> waves;
    public float timeBetweenWaves = 2f;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (true)
        {
            foreach (ObstacleWave wave in waves)
            {
                yield return StartCoroutine(SpawnWave(wave));
                yield return new WaitForSeconds(timeBetweenWaves);
            }
        }
    }

    IEnumerator SpawnWave(ObstacleWave wave)
    {
        for (int i = 0; i < wave.count; i++)
        {
            GameObject enemy = Instantiate(
                wave.enemyPrefab,
                wave.pathPrefab.GetChild(0).position,
                Quaternion.identity
            );

            EnemyMovement movement = enemy.GetComponent<EnemyMovement>();
            movement.path = wave.pathPrefab;
            movement.speed = wave.speed;

            yield return new WaitForSeconds(2.5f);
        }
    }
}
