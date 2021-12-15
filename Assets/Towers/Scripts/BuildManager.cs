using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private TowerPrint towerT;

    public bool CanBuild { get { return towerT != null; } }
    public bool EnergyCheck { get { return Stats.Energy >= towerT.cost; } }

    public void MainSelectTower(TowerPrint towerPrint)
    {
        towerT = towerPrint;
    }

    public void BuildTower(BuildSpot spot)
    {
        if(!EnergyCheck)
        {
            return;
        }
        Stats.Energy -= towerT.cost;
        GameObject tower = Instantiate(towerT.prefab, spot.transform.position, Quaternion.identity);
        spot.tower = tower;
        spot.rend.color = new Color(0, 0, 0, 0);
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
