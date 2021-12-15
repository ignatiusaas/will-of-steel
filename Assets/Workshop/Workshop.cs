using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop : MonoBehaviour
{
    BuildManager buildManager;

    public void BuildTower1()
    {
        buildManager.MainBuildTower(buildManager.tower1Prefab);
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
