using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float waveDelay = 3f;
    public float spawnDelay = 0.5f;
    public static float countdown;
    private float startCountdown = 3f;
    public static int waveI;
    public int startWaveI = 0;
    // Start is called before the first frame update
    void Start()
    {
        waveI = startWaveI;
        countdown = startCountdown;
    }

    // Update is called once per frame
    void Update()
    {
        if(Stats.Lives <= 0)
        {
            Destroy(gameObject);
            return;
        }

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = waveDelay;
        }

        countdown -= Time.deltaTime;
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    IEnumerator SpawnWave()
    {
        waveI++;

        for (int i = 0; i < 7 + (waveI + waveI * 2); i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
