using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{

    public Wave[] waves;
    public int currentWave;

    public IEnumerator StartWaves()
    {
        for ( currentWave = 0; currentWave < waves.Length; currentWave++)
        {
            var wave = waves[currentWave];
            yield return new WaitForSeconds(wave.startDelay);


            IEnumerator spawnEnemies = wave.SpawnEnemies();
            while (spawnEnemies.MoveNext())
            {
                yield return spawnEnemies.Current;
            }


            IEnumerator Checker = wave.CheckEnemiesAlive();
            while (Checker.MoveNext())
                yield return Checker.Current;
        }

        yield return null;
    }

    void Start()
    {
        StartCoroutine(StartWaves());
    }

    void Update()
    {
    }

}
