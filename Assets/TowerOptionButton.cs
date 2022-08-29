using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TowerOptionButton : MonoBehaviour
{

    public Tower towerData;

    public UnityEvent<Tower> onTowerSelection;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Text>().text = towerData.towerName;

        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        onTowerSelection.Invoke(towerData);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
