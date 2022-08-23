using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCounterUI : MonoBehaviour
{

    private WaveManager waveManager;

    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        waveManager = GameObject.FindGameObjectWithTag("WaveManager").GetComponent<WaveManager>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (waveManager.currentWave+1) + " / "+ waveManager.waves.Length;
    }
}
