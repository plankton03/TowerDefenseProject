using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerClickDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //checl click
        //Ray ray = Camera.main.ViewportPointToRay(Input.mousePosition);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                if (hit.transform.gameObject.tag.Equals("TowerBase"))
                {
                    print("Tower selcted");
                    SendMessage("SelectTower",hit.transform.position);//string
                }
            }
        }
    }
}
