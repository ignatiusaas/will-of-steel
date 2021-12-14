using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] wp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        wp = new Transform[transform.childCount];
        for (int i = 0; i < wp.Length; i++)
        {
            wp[i] = transform.GetChild(i);
        }
    }
}
