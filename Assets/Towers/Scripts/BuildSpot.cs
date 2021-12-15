using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildSpot : MonoBehaviour
{
    public Color hoverColor;
    private Color originColor;
    public SpriteRenderer rend;
    public GameObject tower;

    BuildManager buildManager;

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;
        if (tower != null)
            return;
        rend.color = hoverColor;
    }

    void OnMouseExit()
    {
        if (tower != null)
            return;
        rend.color = originColor;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if (tower != null)
        {
            Destroy(tower);
            tower = null;
            Stats.Energy += 3;
            rend.color = originColor;
            return;
        }
        buildManager.BuildTower(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        originColor = rend.color;

        buildManager = BuildManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
