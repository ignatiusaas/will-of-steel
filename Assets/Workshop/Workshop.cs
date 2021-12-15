using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop : MonoBehaviour
{
    BuildManager buildManager;
    public TowerPrint tower1;

    public void SelectTower1()
    {
        buildManager.MainSelectTower(tower1);
    }
    // Start is called before the first frame update
    void Start()
    {
        buildManager = BuildManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
