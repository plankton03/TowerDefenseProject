using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachinegunBulletEffect : MonoBehaviour
{

    public Transform bullet;

    public Transform turretNose;

    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDamage(Transform target) // in class MachinegunAttackEnemy : Rename it 
    {
        var bulletInstance =  Instantiate(bullet,turretNose.position , turretNose.rotation);
        bulletInstance.GetComponent<Rigidbody>().velocity = bulletInstance.forward * bulletSpeed;
        Destroy(bulletInstance.gameObject , 0.5f);
    }
}
