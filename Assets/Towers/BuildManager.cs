using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private GameObject towerT;
    private GameObject ws;

    public GameObject GetTower()
    {
        return towerT;
    }

    public GameObject GetWorkshop()
    {
        return ws;
    }

    public void MainBuildTower(GameObject tower)
    {
        towerT = tower;
    }

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("Multiple anom- BuildManager detected");
            return;
        }
        instance = this;
    }

    public GameObject tower1Prefab;
    public GameObject workshopPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //towerT = tower1Prefab;
        ws = workshopPrefab;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
