using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{

    private Vector3 activeTowerPosition;

    public float yOffset;

    public Vector3 activeTowerPosition1
    {
        get => activeTowerPosition;
        set => activeTowerPosition = value;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void CreateTower(Tower towerData)
    { 
        Instantiate(towerData.towerPrefab, activeTowerPosition + yOffset*Vector3.up, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
