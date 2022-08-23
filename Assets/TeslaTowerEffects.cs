using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeslaTowerEffects : MonoBehaviour
{

    public Transform effect;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

    }
    public void OnAttack(Transform enemy)
    {
        Transform newEffect = Instantiate(effect, enemy.position , effect.rotation);
        Destroy(newEffect.gameObject, 1f);

    }

    public void OnAttack(Transform[] enemies)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            OnAttack(enemies[i]);
        }
    }
}
