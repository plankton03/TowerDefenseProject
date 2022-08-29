using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerOptions : MonoBehaviour
{
    public Transform towerOptionButtonPrafab;

    public Tower[] towersData;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Tower tower in towersData)
        {
            TowerOptionButton button = Instantiate(towerOptionButtonPrafab, transform).GetComponent<TowerOptionButton>();

            button.towerData = tower;
            button.onTowerSelection.AddListener(OnTowerButtonSelected);
        }
    }

    private void OnTowerButtonSelected(Tower towerData)
    {
        SendMessageUpwards("CreateTower",towerData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
