using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMovement : MonoBehaviour
{
    public Transform goal;
    public UnityEngine.AI.NavMeshAgent agent;

    public float minimumDistance;

    public UnityEvent onReach;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    public void SetGoal(Transform goal)
    {
        this.goal = goal;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(goal.position);
        if ((transform.position - goal.position).magnitude <= minimumDistance )
        {
            agent.ResetPath();
            onReach.Invoke();
        }
    }
}
