using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDeathCounter : MonoBehaviour
{

    public Event OnEnemyDeath;

    public int deathCount;

    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        OnEnemyDeath.OnEventCalled.AddListener(OnEnemyDead);   
    }

    private void OnEnemyDead()
    {
        deathCount++;

    }

    // Update is called once per frame
    void Update()
    {
        text.text = deathCount.ToString();

    }
}
