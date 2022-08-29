using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathChecker : MonoBehaviour
{

    public Event EnemyDeathEvent;
    private void OnDestroy()
    {
        EnemyDeathEvent.OnEventCalled.Invoke();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
