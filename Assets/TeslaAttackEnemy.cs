using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TeslaAttackEnemy : BaseAttackEnemy
{

    public int damage;

    public float cooldownTime;

    private List<Health> enemyHealths = new List<Health>();


    public UnityEvent<Transform> OnAttackenemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ApplyPeriodDamage());
    }

    IEnumerator ApplyPeriodDamage()
    {
        while (true)
        {
            while (enemyHealths.Count == 0)
                yield return null;

            for (int i = 0; i < enemyHealths.Count; i++)
            {
                enemyHealths[i].takeDamage(damage);
                OnAttackenemy.Invoke(enemyHealths[i].transform);
            }
            //towerEffects.OnAttack(enemyHealths.Select(EH => EH.transform).ToArray());
            yield return new WaitForSeconds(cooldownTime);
        }

    }

    protected override void OnEnemyTriggerEnter(Collider other)
    {
        enemyHealths.Add(other.GetComponentInChildren<Health>());
    }

    protected override void OnEnemyTriggerExit(Collider other)
    {
        enemyHealths.Remove(other.GetComponentInChildren<Health>());
    }
}
