using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{

    public Wave[] waves;

    public IEnumerator StartWaves()
    {
        foreach (var wave in waves)
        {
            yield return new WaitForSeconds(wave.startDelay);
            
            
            IEnumerator spawnEnemies = wave.SpawnEnemies();
            while (spawnEnemies.MoveNext())
            {
                yield return spawnEnemies.Current;
            }


            IEnumerator Checker  = wave.CheckEnemiesAlive();
            while(Checker.MoveNext())
                yield return Checker.Current;

        }
        yield return null;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartWaves());
    }

    // Update is called once per frame
    void Update()
    {
        //var enumerator = Count();
        //enumerator.MoveNext();

        //print(enumerator.Current);
    }
    //public IEnumerator<int> Count()
    //{
    //    yield return -1;
    //    yield return 1;
    //    yield return 2;
    //    yield return 3;
    //    yield return 4;
    //    yield return 5;
    //    yield return 6;
    //    yield return 7;
    //}
}
