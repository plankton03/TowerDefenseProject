using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelectorUI : MonoBehaviour
{
    public RectTransform towerOptions;

    private RectTransform existingPanel;

    private Vector3 towerPosition;

    private TowerCreator creator;
    // Start is called before the first frame update
    void Start()
    {
        creator = GetComponent<TowerCreator>();
    }

    // Update is called once per frame

    void SelectTower(Vector3 towerPosition) //called by string
    {
        if (existingPanel != null)
        {
            Destroy(existingPanel.gameObject);

        }
        existingPanel = Instantiate(towerOptions, Camera.main.WorldToScreenPoint(towerPosition), Quaternion.identity);
        existingPanel.SetParent(transform);
        this.towerPosition = towerPosition;

        creator.activeTowerPosition1 = towerPosition;
    }
    void Update()
    {
        if (existingPanel)
        {
            existingPanel.position = Camera.main.WorldToScreenPoint(towerPosition);
        }
    }
}
