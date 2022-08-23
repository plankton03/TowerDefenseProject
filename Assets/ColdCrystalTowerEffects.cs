using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdCrystalTowerEffects : MonoBehaviour
{
    public float scaleFactor;

    public ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        scaleFactor = GetComponentInParent<SphereCollider>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one * scaleFactor ;

    }
}
