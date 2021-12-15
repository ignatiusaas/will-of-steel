using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static int Energy;
    public static int Lives;

    public int startEnergy = 7;
    public int startLives = 50;
    // Start is called before the first frame update
    void Start()
    {
        Energy = startEnergy;

        Lives = startLives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
