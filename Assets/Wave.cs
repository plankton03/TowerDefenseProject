using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Wave : MonoBehaviour
{

    public float startDelay;
    public float midSpawnDelay;

    public Transform spawnLocation;

    public Enemy[] enemies;

    public bool areEnemiesAlive = true;

    

    private List<Enemy> enemiesAlive = new List<Enemy>();
    
    void Start()
    {
        
    }

    public IEnumerator SpawnEnemies()
    {
        foreach (var enemy in enemies)
        {
            enemiesAlive.Add(Instantiate(enemy,spawnLocation.position,Quaternion.identity));
            float delay = Random.Range(0, midSpawnDelay);
            yield return new WaitForSeconds(delay);
        }
        yield return null;
    }

    public IEnumerator CheckEnemiesAlive()
    {
        while (!enemiesAlive.All(isNull))
        {
            yield return null;
        }
        areEnemiesAlive = false;
    }

    private bool isNull(Enemy arg)
    {
        return arg == null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
