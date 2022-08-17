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

    public UnityEvent onTargetDeath;

    public IEnumerator Attacking()
    {
        while (targetHealth != null)
        {
            targetHealth.takeDamage(damage);
            yield return new WaitForSeconds(waitTime);
        }
        onTargetDeath.Invoke();
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
