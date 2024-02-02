using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;

    public Transform parentRorate;

    public string enemyTag = "enemy";
    public float range = 15f;
    public float turnSpeed = 10f;
    void Start()
    {
        InvokeRepeating("UpdataTaget",0f,0.5f);
    }

    void UpdataTaget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        
        foreach (GameObject enemy in enemies)
        {
            float distanceToenemy = Vector3.Distance(enemy.transform.position, transform.position);
            if (distanceToenemy < shortDistance)
            {
                shortDistance = distanceToenemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else{
            target = null;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(target == null)
        {
            return;
        }

        Vector3 dir = target.position - transform.position;
        Quaternion lookRoration = Quaternion.LookRotation(dir);
        // Vector3 rotation = lookRoration.eulerAngles;
        Vector3 rotation = Quaternion.Lerp(parentRorate.rotation, lookRoration, Time.deltaTime* turnSpeed).eulerAngles;
        parentRorate.rotation = Quaternion.Euler(0f,rotation.y,0f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
