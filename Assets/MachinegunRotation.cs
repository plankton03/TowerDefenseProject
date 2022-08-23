using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachinegunRotation : MonoBehaviour
{
    private MachinegunAttackEnemy machinegun;
    public Transform turret;

    void Start()
    {
        machinegun = GetComponent<MachinegunAttackEnemy>();
    }

    void Rotation()
    {
        if (machinegun.currentEnemy)
        {
            turret.LookAt(machinegun.currentEnemy.transform);
        }
    }
    void Update()
    {
        Rotation();
    }
}
