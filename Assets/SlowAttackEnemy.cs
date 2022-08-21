using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlowAttackEnemy : BaseAttackEnemy
{

    public float effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    protected override void OnEnemyTriggerEnter(Collider other)
    {
        other.GetComponent<NavMeshAgent>().speed *= effect;
    }

    protected override void OnEnemyTriggerExit(Collider other)
    {
        other.GetComponent<NavMeshAgent>().speed /= effect ;
    }
}
