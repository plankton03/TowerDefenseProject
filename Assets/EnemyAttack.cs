using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyAttack : MonoBehaviour
{

    public Health targetHealth;
    public int damage;
    public float waitTime;

    public bool isAttackDone = false;

    public IEnumerator Attacking()
    {
        while (targetHealth != null)
        {
            targetHealth.takeDamage(damage);
            yield return new WaitForSeconds(waitTime);
        }
        isAttackDone = true;
        yield return null;
    }

    private void OnEnable()
    {
        StartCoroutine(Attacking());
    }

    private void OnDisable()
    {
        StopCoroutine(Attacking());
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
