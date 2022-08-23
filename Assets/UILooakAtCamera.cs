using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILooakAtCamera : MonoBehaviour
{

    private Health health;

    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        Canvas canvas = GetComponent<Canvas>();
        canvas.worldCamera = Camera.main;
        health = GetComponentInParent<Health>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
        image.fillAmount = health.healthRatio;
    }
}
