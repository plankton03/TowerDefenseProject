using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainHealthUI : MonoBehaviour
{

    private Health healthComponent;

    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        healthComponent = GameObject.FindGameObjectWithTag("TargetArea").GetComponent<Health>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = healthComponent.healthPoints.ToString();
    }
}
