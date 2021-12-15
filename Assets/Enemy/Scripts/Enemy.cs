using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;

    private Transform target;
    private int wpI = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = Waypoints.wp[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(Stats.Lives <= 0)
        {
            Destroy(gameObject);
            return;
        }

        Vector2 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector2.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if(wpI >= Waypoints.wp.Length - 1)
        {
            Destroy(gameObject);
            Stats.Lives -= 2;
            return;
        }

        wpI++;
        target = Waypoints.wp[wpI];
    }
}
