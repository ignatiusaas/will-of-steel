using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildSpot : MonoBehaviour
{
    public Color hoverColor;
    private Color originColor;
    private SpriteRenderer rend;
    private GameObject tower;

    BuildManager buildManager;

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTower() == null)
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

        if (buildManager.GetTower() == null)
            return;

        if (tower != null)
        {
            Destroy(tower);
            tower = null;
            rend.color = originColor;
            return;
        }

        GameObject towerT = BuildManager.instance.GetTower();
        tower = Instantiate(towerT, transform.position, transform.rotation);
        rend.color = new Color(0, 0, 0, 0);
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
