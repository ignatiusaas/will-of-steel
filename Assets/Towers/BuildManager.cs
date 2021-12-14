using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private GameObject towerT;

    public GameObject GetTower()
    {
        return towerT;
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

    // Start is called before the first frame update
    void Start()
    {
        towerT = tower1Prefab;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
