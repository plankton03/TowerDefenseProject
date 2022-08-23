using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int healthPoints;
    
    
    // Start is called before the first frame update
    void Start()
    {
        healthPoints = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float healthRatio
    {
        get { return healthPoints * 1.0f / maxHealth; }
    }

    public void takeDamage(int damage)
    {
        healthPoints -= damage;
        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }


}
