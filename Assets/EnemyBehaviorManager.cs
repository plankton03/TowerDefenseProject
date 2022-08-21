using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorManager : MonoBehaviour
{
    public float idleWait;
    enum State
    {
        Idle , Move , Attack , Dead 
    }

    private State currentState;
    private EnemyMovement enemyMovement;
    private EnemyAttack enemyAttack;
    private EnemyInfo enemyInfo;

    void Start()
    {
        
        enemyMovement = gameObject.GetComponent<EnemyMovement>();
        enemyAttack = gameObject.GetComponent<EnemyAttack>();
        enemyInfo = GameObject.FindGameObjectWithTag("EnemyInfo").GetComponent<EnemyInfo>();

        StartCoroutine(Idle());
    }

    IEnumerator Idle()
    {
        currentState = State.Idle;

        yield return new WaitForSeconds(idleWait);

        DecideNextBahavior();
    }

    IEnumerator Move()
    {
        currentState = State.Move;
        enemyMovement.enabled = true;

        while (!enemyMovement.isArrived && enemyMovement.goal)
        {
            yield return null;
        }

        enemyMovement.enabled = false;

        DecideNextBahavior();
    }

    IEnumerator Attack()
    {
        currentState = State.Attack;
        enemyAttack.enabled = true;

        while (!enemyAttack.isAttackDone)
        {
            yield return null;
        }

        enemyAttack.enabled = false;

        DecideNextBahavior();
    }



    private void DecideNextBahavior()
    {
        if (currentState == State.Idle)
        {
            if (enemyInfo.gate)
            {
                enemyMovement.goal = enemyInfo.gate;
            }
            else
            {
                enemyMovement.goal = enemyInfo.afterGate;
            }

            StartCoroutine(Move());
        }
        else if (currentState == State.Move)
        {
            if (enemyInfo.gate)
            {
                enemyAttack.targetHealth = enemyInfo.gate.gameObject.GetComponent<Health>();
                StartCoroutine(Attack());
            }
            else
            {
                StartCoroutine(Idle());
            }
        }
        else if (currentState == State.Attack)
        {
            enemyMovement.goal = enemyInfo.afterGate;
            StartCoroutine(Move());
        }
        else
        {
            
        }

    }

    void Update()
    {
    }
}
