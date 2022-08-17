using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMovement : MonoBehaviour
{
    public Transform goal;
    public UnityEngine.AI.NavMeshAgent agent;
    public float minimumDistance;
    public bool isArrived = false;

 
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void OnEnable()
    {
        isArrived = false;
    }


    void Update()
    {
        agent.SetDestination(goal.position);

        CheckArrival();
    }

    void CheckArrival()
    { 
        if ((transform.position - goal.position).magnitude <= minimumDistance )
        {
            agent.ResetPath();

            isArrived = true;
        }
    }
}
