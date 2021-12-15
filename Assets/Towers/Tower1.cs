using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1 : MonoBehaviour
{
    private Transform target;
    public float range = 20f;
    public string enemyTag = "Enemy";

    public GameObject bulletPrefab;
    public Transform firePoint;

    public float fireRate = 1f;
    public float fireCd = 0f;

    public Transform towerSpinner;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Locate", 0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
            return;

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        float angle = Mathf.Atan2(dir.y, dir.x);
        towerSpinner.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg);

        if(fireCd <= 0f)
        {
            Fire();
            fireCd = 1f / fireRate;
        }

        fireCd -= Time.deltaTime;
    }

    void Locate()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDis = 80f;
        GameObject nearestTarget = null;

        foreach (GameObject enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if (targetDistance < shortestDis)
            {
                shortestDis = targetDistance;
                nearestTarget = enemy;
            }
        }

        if(nearestTarget != null && shortestDis <= range)
        {
            target = nearestTarget.transform;
        }
    }

    void Fire()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
            bullet.Seek(target);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 1, 5, 0.4f);
        Gizmos.DrawSphere(transform.position, range);
    }
}
