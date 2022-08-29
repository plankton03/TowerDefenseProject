using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class CircularLayout : MonoBehaviour
{

    public float radius;
    public float startingAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            float x, y;
            float angle = 2 * Mathf.PI / transform.childCount * i + startingAngle*Mathf.Deg2Rad;
            x = Mathf.Cos(angle) * radius;
            y = Mathf.Sin(angle) * radius;

            child.localPosition = new Vector3(x, y, 0);
        }
    }
}
