using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public EnemyInfo enemyInfo;
    public EnemyMovement enemyMovement;
    public EnemyAttack enemyAttack;

    public int passDamage;
    // Start is called before the first frame update
    void Start()
    {
        enemyMovement = gameObject.GetComponent<EnemyMovement>();
        enemyAttack = gameObject.GetComponent<EnemyAttack>();
        enemyInfo = GameObject.FindGameObjectWithTag("EnemyInfo").GetComponent<EnemyInfo>();
        enemyMovement.goal = (enemyInfo.gate)?enemyInfo.gate : enemyInfo.afterGate;
        if(enemyInfo.gate)
            enemyAttack.targetHealth = enemyInfo.gate.gameObject.GetComponent<Health>();
        enemyAttack.onTargetDeath.AddListener(OnGateDestroyed);
    }

    private void OnGateDestroyed()
    {
        enemyMovement.goal = enemyInfo.afterGate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
