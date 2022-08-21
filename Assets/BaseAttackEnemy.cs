using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAttackEnemy : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnEnemyTriggerEnter(Collider other)
    {

    }

    protected virtual void OnEnemyTriggerExit(Collider other)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            OnEnemyTriggerEnter(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            OnEnemyTriggerExit(other);
        }
    }
}
