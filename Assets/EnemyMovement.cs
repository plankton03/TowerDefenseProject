using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMovement : MonoBehaviour
{
    public Transform goal;
    public UnityEngine.AI.NavMeshAgent agent;
    public float minimumDistance;
    public bool isArrived = false;
    private Coroutine movingCoroutine;


    void Start()
    {
       
    }

    private void OnEnable()
    {
        isArrived = false;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        movingCoroutine = StartCoroutine(Moving());
    }

    private void OnDisable()
    {
        StopCoroutine(movingCoroutine);
    }


    
    protected virtual IEnumerator Moving()
    {
        while (true)
        {
            agent.SetDestination(goal.position);

            CheckArrival();
            
            yield return null;
        }
    }

    void Update()
    {

    }

    protected void CheckArrival()
    {
        if ((transform.position - goal.position).magnitude <= minimumDistance)
        {
            agent.ResetPath();

            isArrived = true;
        }
    }
}
