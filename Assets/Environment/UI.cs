using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text energyText;
    public Text livesText;
    public Text waveText;
    public Text wavecdText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energyText.text = "Energy " + Stats.Energy.ToString();
        livesText.text = "Lives " + Stats.Lives.ToString();
        waveText.text = "Wave " + WaveSpawner.waveI.ToString();
        wavecdText.text = "Until next wave: " + Mathf.Round(WaveSpawner.countdown).ToString();
    }
}
