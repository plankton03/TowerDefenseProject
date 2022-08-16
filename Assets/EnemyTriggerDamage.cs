using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerDamage : MonoBehaviour
{

    public Health health;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {

        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            health.takeDamage(enemy.passDamage);
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
