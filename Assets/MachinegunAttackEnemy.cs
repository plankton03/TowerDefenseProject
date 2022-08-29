using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachinegunAttackEnemy : BaseAttackEnemy
{

    public int damage;

    public float cooldownTime;

    private List<Health> enemyHealths = new List<Health>();

    //public Health Enemy { get; set; }


    //private Health _Enemy;
    //public Health Enemy {
    //    get
    //    {
    //        return _Enemy;
    //    }
    //    set
    //    {
    //        _Enemy = value;
    //    }

    //}




    public Health currentEnemy
    {

        get { return (enemyHealths.Count > 0) ? enemyHealths[0] : null; }
        private set { enemyHealths[0] = value; }
    }

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

            //enemyHealths[0].takeDamage(damage);
            currentEnemy.takeDamage(damage);

            SendMessage("OnDamage", currentEnemy.transform);
            if (currentEnemy.healthRatio <= 0)
                enemyHealths.Remove(currentEnemy);
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
